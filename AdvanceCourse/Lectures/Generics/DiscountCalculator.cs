
namespace CSharpIntermediateChallenges.AdvanceCourse.Lectures.Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product) {
            return product.Price;
        }
    }
}