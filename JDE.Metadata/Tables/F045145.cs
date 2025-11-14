using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F045145 - .
/// </summary>
public class F045145 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G2TOR.
        /// </summary>
        public const string G2TOR = "G2TOR";

        /// <summary>
        /// G2EIN.
        /// </summary>
        public const string G2EIN = "G2EIN";

        /// <summary>
        /// G2TAX.
        /// </summary>
        public const string G2TAX = "G2TAX";

        /// <summary>
        /// G2AA.
        /// </summary>
        public const string G2AA = "G2AA";

        /// <summary>
        /// G2CUSNU.
        /// </summary>
        public const string G2CUSNU = "G2CUSNU";

        /// <summary>
        /// G2TXYR.
        /// </summary>
        public const string G2TXYR = "G2TXYR";

        /// <summary>
        /// G2SEQUEN.
        /// </summary>
        public const string G2SEQUEN = "G2SEQUEN";

        /// <summary>
        /// G2TORG.
        /// </summary>
        public const string G2TORG = "G2TORG";

        /// <summary>
        /// G2USER.
        /// </summary>
        public const string G2USER = "G2USER";

        /// <summary>
        /// G2UPMJ.
        /// </summary>
        public const string G2UPMJ = "G2UPMJ";

        /// <summary>
        /// G2UPMT.
        /// </summary>
        public const string G2UPMT = "G2UPMT";

        /// <summary>
        /// G2JOBN.
        /// </summary>
        public const string G2JOBN = "G2JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F045145";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G2TOR", "G2TOR", JdeDataType.String, 4, true, true),
        new JdeField("G2EIN", "G2EIN", JdeDataType.String, 40, true, true),
        new JdeField("G2TAX", "G2TAX", JdeDataType.String, 40, true, true),
        new JdeField("G2AA", "G2AA", JdeDataType.Numeric),
        new JdeField("G2CUSNU", "G2CUSNU", JdeDataType.String, 26),
        new JdeField("G2TXYR", "G2TXYR", JdeDataType.Numeric, null, true, true),
        new JdeField("G2SEQUEN", "G2SEQUEN", JdeDataType.Numeric),
        new JdeField("G2TORG", "G2TORG", JdeDataType.String, 20),
        new JdeField("G2USER", "G2USER", JdeDataType.String, 20),
        new JdeField("G2UPMJ", "G2UPMJ", JdeDataType.Numeric),
        new JdeField("G2UPMT", "G2UPMT", JdeDataType.Numeric),
        new JdeField("G2JOBN", "G2JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F045145_0", "Primary Key on G2TOR, G2EIN, G2TAX, G2TXYR", new[] { "G2TOR", "G2EIN", "G2TAX", "G2TXYR" }, isUnique: true, isPrimaryKey: true)
    };
}
