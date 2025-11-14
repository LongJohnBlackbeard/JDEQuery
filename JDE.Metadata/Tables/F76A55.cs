using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A55 - .
/// </summary>
public class F76A55 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HWA76TC.
        /// </summary>
        public const string HWA76TC = "HWA76TC";

        /// <summary>
        /// HWA76WCN.
        /// </summary>
        public const string HWA76WCN = "HWA76WCN";

        /// <summary>
        /// HWA76ST.
        /// </summary>
        public const string HWA76ST = "HWA76ST";

        /// <summary>
        /// HWA76AA.
        /// </summary>
        public const string HWA76AA = "HWA76AA";

        /// <summary>
        /// HWA76CED.
        /// </summary>
        public const string HWA76CED = "HWA76CED";

        /// <summary>
        /// HWA76WOCN.
        /// </summary>
        public const string HWA76WOCN = "HWA76WOCN";

        /// <summary>
        /// HWKCO.
        /// </summary>
        public const string HWKCO = "HWKCO";

        /// <summary>
        /// HWBCRC.
        /// </summary>
        public const string HWBCRC = "HWBCRC";

        /// <summary>
        /// HWCRCD.
        /// </summary>
        public const string HWCRCD = "HWCRCD";

        /// <summary>
        /// HWUSER.
        /// </summary>
        public const string HWUSER = "HWUSER";

        /// <summary>
        /// HWPID.
        /// </summary>
        public const string HWPID = "HWPID";

        /// <summary>
        /// HWJOBN.
        /// </summary>
        public const string HWJOBN = "HWJOBN";

        /// <summary>
        /// HWUPMJ.
        /// </summary>
        public const string HWUPMJ = "HWUPMJ";

        /// <summary>
        /// HWUPMT.
        /// </summary>
        public const string HWUPMT = "HWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A55";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HWA76TC", "HWA76TC", JdeDataType.Numeric, null, true, true),
        new JdeField("HWA76WCN", "HWA76WCN", JdeDataType.String, 50, true, true),
        new JdeField("HWA76ST", "HWA76ST", JdeDataType.String, 4, true, true),
        new JdeField("HWA76AA", "HWA76AA", JdeDataType.Numeric),
        new JdeField("HWA76CED", "HWA76CED", JdeDataType.Numeric),
        new JdeField("HWA76WOCN", "HWA76WOCN", JdeDataType.String, 50),
        new JdeField("HWKCO", "HWKCO", JdeDataType.String, 10),
        new JdeField("HWBCRC", "HWBCRC", JdeDataType.String, 6),
        new JdeField("HWCRCD", "HWCRCD", JdeDataType.String, 6),
        new JdeField("HWUSER", "HWUSER", JdeDataType.String, 20),
        new JdeField("HWPID", "HWPID", JdeDataType.String, 20),
        new JdeField("HWJOBN", "HWJOBN", JdeDataType.String, 20),
        new JdeField("HWUPMJ", "HWUPMJ", JdeDataType.Numeric),
        new JdeField("HWUPMT", "HWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A55_0", "Primary Key on HWA76TC, HWA76WCN, HWA76ST", new[] { "HWA76TC", "HWA76WCN", "HWA76ST" }, isUnique: true, isPrimaryKey: true)
    };
}
