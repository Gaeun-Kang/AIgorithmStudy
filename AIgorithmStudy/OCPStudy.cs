using System;
using System.Collections.Generic;

class CallManager
{
    //유저의 감정 상태를 정의하는 enum
    public enum UserTension
    {
        Idle,          
        Annoyed,       
        Comfortable,   
        Tension       
    }

    //걸려오는 전화 타입을 정의하는 enum
    public enum CallType
    {
        Friend,   
        Family,   
        Boss      
    }

    // 초기 유저의 감정 상태
    private UserTension _state = UserTension.Idle;

    // 전략 패턴을 위한 인터페이스 
    // 각 전화 유형 클래스는 이 인터페이스를 상속받아 메서드를 구현
    public interface ICallStrategy
    {
        void HandleCall(ref UserTension state);
    }

    //인터페이스 상속
    public class FriendCall : ICallStrategy
    {
        public void HandleCall(ref UserTension state)
        {
            state = UserTension.Annoyed;
            Console.WriteLine("친구에게서 전화가 왔습니다. 상태: Annoyed");
        }
    }

    //인터페이스 상속
    public class FamilyCall : ICallStrategy
    {
        public void HandleCall(ref UserTension state)
        {
            state = UserTension.Comfortable;
            Console.WriteLine("가족에게서 전화가 왔습니다. 상태: Comfortable");
        }
    }

    //인터페이스 상속
    public class BossCall : ICallStrategy
    {
        public void HandleCall(ref UserTension state)
        {
            state = UserTension.Tension;
            Console.WriteLine("상사에게서 전화가 왔습니다. 상태: Tension");
        }
    }

    // ✅ 전화 타입과 전략을 매칭하는 Dictionary
    // OCP(개방-폐쇄 원칙) 적용: 새로운 전화 타입을 추가할 때 이 딕셔너리에만 등록하면 됨
    private readonly Dictionary<CallType, ICallStrategy> _strategies;

    // ✅ 생성자에서 전략 객체들을 미리 Dictionary에 등록
    public CallManager()
    {
        _strategies = new Dictionary<CallType, ICallStrategy>
        {
            { CallType.Friend, new FriendCall() },
            { CallType.Family, new FamilyCall() },
            { CallType.Boss, new BossCall() }
        };
    }

    //전화가 왔을 때 처리하는 메서드
    // 전략을 Dictionary에서 가져와 실행하며 상태를 변경
    public void GetCall(CallType callType)
    {
        if (_strategies.ContainsKey(callType))
        {
            _strategies[callType].HandleCall(ref _state);
        }
        else
        {
            Console.WriteLine("알 수 없는 전화 유형입니다.");
        }
    }

    //현재 상태를 출력하는 메서드
    public void PrintState()
    {
        Console.WriteLine($"현재 상태: {_state}");
    }
}

class User
{
    static void ocp()
    {
        // CallManager 객체 생성
        var callManager = new CallManager();


        callManager.GetCall(CallManager.CallType.Friend);  // 친구 전화 -> Annoyed 출력
        callManager.PrintState();

        callManager.GetCall(CallManager.CallType.Family);  // 가족 전화 -> Comfortable 출력
        callManager.PrintState();

        callManager.GetCall(CallManager.CallType.Boss);    // 상사 전화 -> Tension 출력
        callManager.PrintState();

    }
}