namespace PerfectNumbers{
	public class Solution{
		public void solve(){

		}

		public bool isPerfect(int n){
			int sum_of_factors = 1;
			for(int i = 2; i*i <= n; i++){
				if(n%i == 0){
					sum_of_factors += i + n/i;
				}
			}
			if(sum_of_factors == n){
				return true;
			}
			else{
				return false;
			}
		}
	}
}
