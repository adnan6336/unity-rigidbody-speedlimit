if(Mathf.Abs(GetComponent<Rigidbody>().velocity.y) > maxSpeed )
		{
			// clamp velocity:
			Vector3 newVelocity = GetComponent<Rigidbody>().velocity.normalized;
			newVelocity *= maxSpeed;
			GetComponent<Rigidbody>().velocity = newVelocity;
//			print("OverLoaded");
		}
