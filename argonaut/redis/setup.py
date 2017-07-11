from setuptools import setup

setup(name='quoteimporter',
      version='0.1',
      description='Quote importer to redis cache',
      url='http://github.com/hckeyguy33/thirtydaychallenge',
      author='hckeyguy33',
      author_email='hckeyguy33@gmail.com',
      license='MIT',
      packages=['quoteimporter'],
      install_requires=['redis',
			'requests'],
      zip_safe=False)

