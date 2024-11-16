namespace DiwaliCelebration.OCP
{
    public class DiwaliDecorationService
    {
        private readonly List<IDecoration> _decorations;

        public DiwaliDecorationService(List<IDecoration> decorations)
        {
            _decorations = decorations;
        }

        public void Decorate()
        {
            foreach (var decoration in _decorations)
            {
                decoration.Apply();
            }
        }
    }
}
