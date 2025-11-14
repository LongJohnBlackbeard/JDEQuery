using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7617B - .
/// </summary>
public class F7617B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSBCTF.
        /// </summary>
        public const string TSBCTF = "TSBCTF";

        /// <summary>
        /// TSDL05.
        /// </summary>
        public const string TSDL05 = "TSDL05";

        /// <summary>
        /// TSDL06.
        /// </summary>
        public const string TSDL06 = "TSDL06";

        /// <summary>
        /// TSBFII.
        /// </summary>
        public const string TSBFII = "TSBFII";

        /// <summary>
        /// TSBFIP.
        /// </summary>
        public const string TSBFIP = "TSBFIP";

        /// <summary>
        /// TSBNO1.
        /// </summary>
        public const string TSBNO1 = "TSBNO1";

        /// <summary>
        /// TSBNO2.
        /// </summary>
        public const string TSBNO2 = "TSBNO2";

        /// <summary>
        /// TSBNO3.
        /// </summary>
        public const string TSBNO3 = "TSBNO3";

        /// <summary>
        /// TSBNO4.
        /// </summary>
        public const string TSBNO4 = "TSBNO4";

        /// <summary>
        /// TSBNO5.
        /// </summary>
        public const string TSBNO5 = "TSBNO5";

        /// <summary>
        /// TSBNO6.
        /// </summary>
        public const string TSBNO6 = "TSBNO6";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSPID.
        /// </summary>
        public const string TSPID = "TSPID";

        /// <summary>
        /// TSJOBN.
        /// </summary>
        public const string TSJOBN = "TSJOBN";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSTDAY.
        /// </summary>
        public const string TSTDAY = "TSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7617B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSBCTF", "TSBCTF", JdeDataType.String, 4, true, true),
        new JdeField("TSDL05", "TSDL05", JdeDataType.String, 60),
        new JdeField("TSDL06", "TSDL06", JdeDataType.String, 60),
        new JdeField("TSBFII", "TSBFII", JdeDataType.String, 2),
        new JdeField("TSBFIP", "TSBFIP", JdeDataType.String, 2),
        new JdeField("TSBNO1", "TSBNO1", JdeDataType.Numeric),
        new JdeField("TSBNO2", "TSBNO2", JdeDataType.Numeric),
        new JdeField("TSBNO3", "TSBNO3", JdeDataType.Numeric),
        new JdeField("TSBNO4", "TSBNO4", JdeDataType.Numeric),
        new JdeField("TSBNO5", "TSBNO5", JdeDataType.Numeric),
        new JdeField("TSBNO6", "TSBNO6", JdeDataType.Numeric),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSPID", "TSPID", JdeDataType.String, 20),
        new JdeField("TSJOBN", "TSJOBN", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSTDAY", "TSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7617B_0", "Primary Key on TSBCTF", new[] { "TSBCTF" }, isUnique: true, isPrimaryKey: true)
    };
}
