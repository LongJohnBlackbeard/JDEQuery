using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B67 - .
/// </summary>
public class F31B67 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAWOPID.
        /// </summary>
        public const string QAWOPID = "QAWOPID";

        /// <summary>
        /// QAQTST.
        /// </summary>
        public const string QAQTST = "QAQTST";

        /// <summary>
        /// QAWTBID.
        /// </summary>
        public const string QAWTBID = "QAWTBID";

        /// <summary>
        /// QAQASEQ.
        /// </summary>
        public const string QAQASEQ = "QAQASEQ";

        /// <summary>
        /// QATSTRSNM.
        /// </summary>
        public const string QATSTRSNM = "QATSTRSNM";

        /// <summary>
        /// QANUMT.
        /// </summary>
        public const string QANUMT = "QANUMT";

        /// <summary>
        /// QAQABLRUL.
        /// </summary>
        public const string QAQABLRUL = "QAQABLRUL";

        /// <summary>
        /// QAURCD.
        /// </summary>
        public const string QAURCD = "QAURCD";

        /// <summary>
        /// QAURAT.
        /// </summary>
        public const string QAURAT = "QAURAT";

        /// <summary>
        /// QAURRF.
        /// </summary>
        public const string QAURRF = "QAURRF";

        /// <summary>
        /// QAURAB.
        /// </summary>
        public const string QAURAB = "QAURAB";

        /// <summary>
        /// QAURDT.
        /// </summary>
        public const string QAURDT = "QAURDT";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QATDAY.
        /// </summary>
        public const string QATDAY = "QATDAY";

        /// <summary>
        /// QADLAB.
        /// </summary>
        public const string QADLAB = "QADLAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B67";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAWOPID", "QAWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("QAQTST", "QAQTST", JdeDataType.String, 50, true, true),
        new JdeField("QAWTBID", "QAWTBID", JdeDataType.Numeric, null, true, true),
        new JdeField("QAQASEQ", "QAQASEQ", JdeDataType.Numeric),
        new JdeField("QATSTRSNM", "QATSTRSNM", JdeDataType.String, 60),
        new JdeField("QANUMT", "QANUMT", JdeDataType.String, 2),
        new JdeField("QAQABLRUL", "QAQABLRUL", JdeDataType.String, 10),
        new JdeField("QAURCD", "QAURCD", JdeDataType.String, 4),
        new JdeField("QAURAT", "QAURAT", JdeDataType.Numeric),
        new JdeField("QAURRF", "QAURRF", JdeDataType.String, 30),
        new JdeField("QAURAB", "QAURAB", JdeDataType.Numeric),
        new JdeField("QAURDT", "QAURDT", JdeDataType.Numeric),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QATDAY", "QATDAY", JdeDataType.Numeric),
        new JdeField("QADLAB", "QADLAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B67_0", "Primary Key on QAWOPID, QAQTST, QAWTBID", new[] { "QAWOPID", "QAQTST", "QAWTBID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B67_2", "Index on QAWTBID, QAQTST", new[] { "QAWTBID", "QAQTST" })
    };
}
