
public class Collisions : Actor
{


    private static Color BLUE = new Color(0, 0, 204);

    public void HandleCollisions(Cast cast)
    {
        Turret turret = (Turret)cast.GetFirstActor("turret");

        Enemies enemy = (Enemies)cast.GetFirstActor("enemy");

        if (turret.GetPosition().Equals(enemy.GetPosition()))
        {
            enemy.SetColor(BLUE);
        }
    }



    public void AnotherCollision()
    {
        
    }



}