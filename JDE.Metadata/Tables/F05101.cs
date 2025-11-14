using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05101 - .
/// </summary>
public class F05101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYCUCD.
        /// </summary>
        public const string CYCUCD = "CYCUCD";

        /// <summary>
        /// CYINEC.
        /// </summary>
        public const string CYINEC = "CYINEC";

        /// <summary>
        /// CYEDTF.
        /// </summary>
        public const string CYEDTF = "CYEDTF";

        /// <summary>
        /// CYEDTT.
        /// </summary>
        public const string CYEDTT = "CYEDTT";

        /// <summary>
        /// CYCUCN.
        /// </summary>
        public const string CYCUCN = "CYCUCN";

        /// <summary>
        /// CYUNT.
        /// </summary>
        public const string CYUNT = "CYUNT";

        /// <summary>
        /// CYCUCT.
        /// </summary>
        public const string CYCUCT = "CYCUCT";

        /// <summary>
        /// CYTATY.
        /// </summary>
        public const string CYTATY = "CYTATY";

        /// <summary>
        /// CYUSER.
        /// </summary>
        public const string CYUSER = "CYUSER";

        /// <summary>
        /// CYPID.
        /// </summary>
        public const string CYPID = "CYPID";

        /// <summary>
        /// CYJOBN.
        /// </summary>
        public const string CYJOBN = "CYJOBN";

        /// <summary>
        /// CYUPMJ.
        /// </summary>
        public const string CYUPMJ = "CYUPMJ";

        /// <summary>
        /// CYUPMT.
        /// </summary>
        public const string CYUPMT = "CYUPMT";

        /// <summary>
        /// CYUNCON.
        /// </summary>
        public const string CYUNCON = "CYUNCON";
    }

    /// <inheritdoc />
    public override string TableName => "F05101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYCUCD", "CYCUCD", JdeDataType.String, 20, true, true),
        new JdeField("CYINEC", "CYINEC", JdeDataType.String, 20, true, true),
        new JdeField("CYEDTF", "CYEDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("CYEDTT", "CYEDTT", JdeDataType.Numeric, null, true, true),
        new JdeField("CYCUCN", "CYCUCN", JdeDataType.String, 60),
        new JdeField("CYUNT", "CYUNT", JdeDataType.Numeric),
        new JdeField("CYCUCT", "CYCUCT", JdeDataType.Numeric),
        new JdeField("CYTATY", "CYTATY", JdeDataType.String, 20),
        new JdeField("CYUSER", "CYUSER", JdeDataType.String, 20),
        new JdeField("CYPID", "CYPID", JdeDataType.String, 20),
        new JdeField("CYJOBN", "CYJOBN", JdeDataType.String, 20),
        new JdeField("CYUPMJ", "CYUPMJ", JdeDataType.Numeric),
        new JdeField("CYUPMT", "CYUPMT", JdeDataType.Numeric),
        new JdeField("CYUNCON", "CYUNCON", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05101_0", "Primary Key on CYCUCD, CYINEC, CYEDTF, CYEDTT", new[] { "CYCUCD", "CYINEC", "CYEDTF", "CYEDTT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05101_2", "Index on CYINEC", new[] { "CYINEC" })
    };
}
