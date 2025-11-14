using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P502 - .
/// </summary>
public class F76P502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALH76LECO.
        /// </summary>
        public const string ALH76LECO = "ALH76LECO";

        /// <summary>
        /// ALP76ALSU.
        /// </summary>
        public const string ALP76ALSU = "ALP76ALSU";

        /// <summary>
        /// ALDCT.
        /// </summary>
        public const string ALDCT = "ALDCT";

        /// <summary>
        /// ALLT.
        /// </summary>
        public const string ALLT = "ALLT";

        /// <summary>
        /// ALP76CLNM.
        /// </summary>
        public const string ALP76CLNM = "ALP76CLNM";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALJOBN.
        /// </summary>
        public const string ALJOBN = "ALJOBN";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALUPMT.
        /// </summary>
        public const string ALUPMT = "ALUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALH76LECO", "ALH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("ALP76ALSU", "ALP76ALSU", JdeDataType.String, 20, true, true),
        new JdeField("ALDCT", "ALDCT", JdeDataType.String, 4, true, true),
        new JdeField("ALLT", "ALLT", JdeDataType.String, 4, true, true),
        new JdeField("ALP76CLNM", "ALP76CLNM", JdeDataType.String, 6),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALJOBN", "ALJOBN", JdeDataType.String, 20),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric),
        new JdeField("ALUPMT", "ALUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P502_0", "Primary Key on ALH76LECO, ALP76ALSU, ALDCT, ALLT", new[] { "ALH76LECO", "ALP76ALSU", "ALDCT", "ALLT" }, isUnique: true, isPrimaryKey: true)
    };
}
