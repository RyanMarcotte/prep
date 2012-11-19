namespace prep.utility.filtering
{
  public interface ICreateMatchers<ItemToFilter, TProperty>
  {
    IMatchAn<ItemToFilter> equal_to(TProperty value);
    IMatchAn<ItemToFilter> equal_to_any(params TProperty[] values);
    IMatchAn<ItemToFilter> not_equal_to(TProperty value);
  }
}