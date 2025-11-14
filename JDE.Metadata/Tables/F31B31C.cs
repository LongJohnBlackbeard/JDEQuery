using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B31C - .
/// </summary>
public class F31B31C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCMCU.
        /// </summary>
        public const string BCMCU = "BCMCU";

        /// <summary>
        /// BCWLOTN.
        /// </summary>
        public const string BCWLOTN = "BCWLOTN";

        /// <summary>
        /// BCWCOST.
        /// </summary>
        public const string BCWCOST = "BCWCOST";

        /// <summary>
        /// BCU.
        /// </summary>
        public const string BCU = "BCU";

        /// <summary>
        /// BCWVUM.
        /// </summary>
        public const string BCWVUM = "BCWVUM";

        /// <summary>
        /// BCUNCS.
        /// </summary>
        public const string BCUNCS = "BCUNCS";

        /// <summary>
        /// BCAA.
        /// </summary>
        public const string BCAA = "BCAA";

        /// <summary>
        /// BCWCO.
        /// </summary>
        public const string BCWCO = "BCWCO";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B31C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCMCU", "BCMCU", JdeDataType.String, 24, true, true),
        new JdeField("BCWLOTN", "BCWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("BCWCOST", "BCWCOST", JdeDataType.String, 24, true, true),
        new JdeField("BCU", "BCU", JdeDataType.Numeric),
        new JdeField("BCWVUM", "BCWVUM", JdeDataType.String, 6),
        new JdeField("BCUNCS", "BCUNCS", JdeDataType.Numeric),
        new JdeField("BCAA", "BCAA", JdeDataType.Numeric),
        new JdeField("BCWCO", "BCWCO", JdeDataType.String, 2),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B31C_0", "Primary Key on BCMCU, BCWLOTN, BCWCOST", new[] { "BCMCU", "BCWLOTN", "BCWCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
