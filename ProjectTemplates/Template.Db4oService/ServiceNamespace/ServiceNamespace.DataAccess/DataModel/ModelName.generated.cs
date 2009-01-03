using @ServiceNamespace@.DataAccess.Base;

namespace @ServiceNamespace@.DataAccess.DataModel
{
	public partial class @ModelName@ : BusinessBase<int>
	{

		public override int GetHashCode()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			sb.Append(this.GetType().FullName);

			return sb.ToString().GetHashCode();
		}
	}
}