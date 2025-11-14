using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I818 - .
/// </summary>
public class F75I818 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NNK74LECO.
        /// </summary>
        public const string NNK74LECO = "NNK74LECO";

        /// <summary>
        /// NNI75GSTU.
        /// </summary>
        public const string NNI75GSTU = "NNI75GSTU";

        /// <summary>
        /// NNK74LEDT.
        /// </summary>
        public const string NNK74LEDT = "NNK74LEDT";

        /// <summary>
        /// NNK74ISPL.
        /// </summary>
        public const string NNK74ISPL = "NNK74ISPL";

        /// <summary>
        /// NNI75NNED.
        /// </summary>
        public const string NNI75NNED = "NNI75NNED";

        /// <summary>
        /// NNK74LESA.
        /// </summary>
        public const string NNK74LESA = "NNK74LESA";

        /// <summary>
        /// NNK74NN.
        /// </summary>
        public const string NNK74NN = "NNK74NN";

        /// <summary>
        /// NNUSER.
        /// </summary>
        public const string NNUSER = "NNUSER";

        /// <summary>
        /// NNPID.
        /// </summary>
        public const string NNPID = "NNPID";

        /// <summary>
        /// NNJOBN.
        /// </summary>
        public const string NNJOBN = "NNJOBN";

        /// <summary>
        /// NNUPMJ.
        /// </summary>
        public const string NNUPMJ = "NNUPMJ";

        /// <summary>
        /// NNUPMT.
        /// </summary>
        public const string NNUPMT = "NNUPMT";

        /// <summary>
        /// NNYFUTDT1.
        /// </summary>
        public const string NNYFUTDT1 = "NNYFUTDT1";

        /// <summary>
        /// NNFUT6.
        /// </summary>
        public const string NNFUT6 = "NNFUT6";

        /// <summary>
        /// NNYT04.
        /// </summary>
        public const string NNYT04 = "NNYT04";

        /// <summary>
        /// NNYFLAG.
        /// </summary>
        public const string NNYFLAG = "NNYFLAG";

        /// <summary>
        /// NNYNUM1.
        /// </summary>
        public const string NNYNUM1 = "NNYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I818";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NNK74LECO", "NNK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("NNI75GSTU", "NNI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("NNK74LEDT", "NNK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("NNK74ISPL", "NNK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("NNI75NNED", "NNI75NNED", JdeDataType.Numeric, null, true, true),
        new JdeField("NNK74LESA", "NNK74LESA", JdeDataType.String, 10),
        new JdeField("NNK74NN", "NNK74NN", JdeDataType.Numeric),
        new JdeField("NNUSER", "NNUSER", JdeDataType.String, 20),
        new JdeField("NNPID", "NNPID", JdeDataType.String, 20),
        new JdeField("NNJOBN", "NNJOBN", JdeDataType.String, 20),
        new JdeField("NNUPMJ", "NNUPMJ", JdeDataType.Numeric),
        new JdeField("NNUPMT", "NNUPMT", JdeDataType.Numeric),
        new JdeField("NNYFUTDT1", "NNYFUTDT1", JdeDataType.Numeric),
        new JdeField("NNFUT6", "NNFUT6", JdeDataType.String, 60),
        new JdeField("NNYT04", "NNYT04", JdeDataType.String, 2),
        new JdeField("NNYFLAG", "NNYFLAG", JdeDataType.String, 2),
        new JdeField("NNYNUM1", "NNYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I818_0", "Primary Key on NNK74LECO, NNI75GSTU, NNK74LEDT, NNK74ISPL, NNI75NNED", new[] { "NNK74LECO", "NNI75GSTU", "NNK74LEDT", "NNK74ISPL", "NNI75NNED" }, isUnique: true, isPrimaryKey: true)
    };
}
