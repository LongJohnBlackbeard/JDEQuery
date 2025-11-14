using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F045141 - .
/// </summary>
public class F045141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G1CO.
        /// </summary>
        public const string G1CO = "G1CO";

        /// <summary>
        /// G1TOR.
        /// </summary>
        public const string G1TOR = "G1TOR";

        /// <summary>
        /// G1TAX.
        /// </summary>
        public const string G1TAX = "G1TAX";

        /// <summary>
        /// G1AN8.
        /// </summary>
        public const string G1AN8 = "G1AN8";

        /// <summary>
        /// G1AA.
        /// </summary>
        public const string G1AA = "G1AA";

        /// <summary>
        /// G1AT1.
        /// </summary>
        public const string G1AT1 = "G1AT1";

        /// <summary>
        /// G1AT2.
        /// </summary>
        public const string G1AT2 = "G1AT2";

        /// <summary>
        /// G1AT3.
        /// </summary>
        public const string G1AT3 = "G1AT3";

        /// <summary>
        /// G1AT4.
        /// </summary>
        public const string G1AT4 = "G1AT4";

        /// <summary>
        /// G1AT5.
        /// </summary>
        public const string G1AT5 = "G1AT5";

        /// <summary>
        /// G1AC01.
        /// </summary>
        public const string G1AC01 = "G1AC01";

        /// <summary>
        /// G1AC02.
        /// </summary>
        public const string G1AC02 = "G1AC02";

        /// <summary>
        /// G1AC03.
        /// </summary>
        public const string G1AC03 = "G1AC03";

        /// <summary>
        /// G1AC04.
        /// </summary>
        public const string G1AC04 = "G1AC04";

        /// <summary>
        /// G1AC05.
        /// </summary>
        public const string G1AC05 = "G1AC05";

        /// <summary>
        /// G1AC06.
        /// </summary>
        public const string G1AC06 = "G1AC06";

        /// <summary>
        /// G1AC07.
        /// </summary>
        public const string G1AC07 = "G1AC07";

        /// <summary>
        /// G1AC08.
        /// </summary>
        public const string G1AC08 = "G1AC08";

        /// <summary>
        /// G1AC09.
        /// </summary>
        public const string G1AC09 = "G1AC09";

        /// <summary>
        /// G1AC10.
        /// </summary>
        public const string G1AC10 = "G1AC10";

        /// <summary>
        /// G1DOC.
        /// </summary>
        public const string G1DOC = "G1DOC";

        /// <summary>
        /// G1DCT.
        /// </summary>
        public const string G1DCT = "G1DCT";

        /// <summary>
        /// G1DGJ.
        /// </summary>
        public const string G1DGJ = "G1DGJ";

        /// <summary>
        /// G1CN.
        /// </summary>
        public const string G1CN = "G1CN";

        /// <summary>
        /// G1DKJ.
        /// </summary>
        public const string G1DKJ = "G1DKJ";

        /// <summary>
        /// G1EXR.
        /// </summary>
        public const string G1EXR = "G1EXR";

        /// <summary>
        /// G1EIN.
        /// </summary>
        public const string G1EIN = "G1EIN";

        /// <summary>
        /// G1ST.
        /// </summary>
        public const string G1ST = "G1ST";
    }

    /// <inheritdoc />
    public override string TableName => "F045141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G1CO", "G1CO", JdeDataType.String, 10, true, true),
        new JdeField("G1TOR", "G1TOR", JdeDataType.String, 4, true, true),
        new JdeField("G1TAX", "G1TAX", JdeDataType.String, 40),
        new JdeField("G1AN8", "G1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("G1AA", "G1AA", JdeDataType.Numeric),
        new JdeField("G1AT1", "G1AT1", JdeDataType.String, 6),
        new JdeField("G1AT2", "G1AT2", JdeDataType.String, 2),
        new JdeField("G1AT3", "G1AT3", JdeDataType.String, 2),
        new JdeField("G1AT4", "G1AT4", JdeDataType.String, 2),
        new JdeField("G1AT5", "G1AT5", JdeDataType.String, 2),
        new JdeField("G1AC01", "G1AC01", JdeDataType.String, 6),
        new JdeField("G1AC02", "G1AC02", JdeDataType.String, 6),
        new JdeField("G1AC03", "G1AC03", JdeDataType.String, 6),
        new JdeField("G1AC04", "G1AC04", JdeDataType.String, 6),
        new JdeField("G1AC05", "G1AC05", JdeDataType.String, 6),
        new JdeField("G1AC06", "G1AC06", JdeDataType.String, 6),
        new JdeField("G1AC07", "G1AC07", JdeDataType.String, 6),
        new JdeField("G1AC08", "G1AC08", JdeDataType.String, 6),
        new JdeField("G1AC09", "G1AC09", JdeDataType.String, 6),
        new JdeField("G1AC10", "G1AC10", JdeDataType.String, 6),
        new JdeField("G1DOC", "G1DOC", JdeDataType.Numeric),
        new JdeField("G1DCT", "G1DCT", JdeDataType.String, 4),
        new JdeField("G1DGJ", "G1DGJ", JdeDataType.Numeric),
        new JdeField("G1CN", "G1CN", JdeDataType.String, 16),
        new JdeField("G1DKJ", "G1DKJ", JdeDataType.Numeric),
        new JdeField("G1EXR", "G1EXR", JdeDataType.String, 60),
        new JdeField("G1EIN", "G1EIN", JdeDataType.String, 40),
        new JdeField("G1ST", "G1ST", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F045141_0", "Primary Key on G1AN8, G1CO, G1TOR, G1ST", new[] { "G1AN8", "G1CO", "G1TOR", "G1ST" }, isUnique: true, isPrimaryKey: true)
    };
}
