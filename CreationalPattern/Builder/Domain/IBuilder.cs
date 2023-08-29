namespace Builder.Domain;

public interface IBuilder<out T>
{
    void Reset();
    IBuilder<T> Person(Person person);
    IBuilder<T> Responsable(Person person);
    IBuilder<T> Enroll(Modality modality);
    T Build();
    T Update();
}