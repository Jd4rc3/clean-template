namespace Soldaria.TemplateSolidaria.Domain.UseCase;

public interface IUseCase<T, TP>
{
    T Execute(TP type);
}