using UnityEngine;

namespace _Scene
{
    public class CreatePlaneFromPrimitive : MonoBehaviour
    {
        public int width;
        public int depth;
        public float memory;

        private void Start()
        {
            for(var i = 0 ; i < width ; i++)for (var j = 0; j < depth; j++){CreateCube(i, j);}
        }

        private static GameObject CreateCube(int x ,int z)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(x, 0f, z);
            cube.name = "Cube_" + x.ToString() + "_" + z.ToString();
            var mat = new Material(Shader.Find("Standard"));
            var rend = cube.GetComponent<Renderer>();
            rend.material = mat;
            mat.color = new Color(Random.Range(0,50),Random.Range(0,50),Random.Range(0,50));
            return cube;
        }
    }
}
