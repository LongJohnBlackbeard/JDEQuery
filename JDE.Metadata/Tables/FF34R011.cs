using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34R011 - .
/// </summary>
public class FF34R011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCDFRCID.
        /// </summary>
        public const string RCDFRCID = "RCDFRCID";

        /// <summary>
        /// RCDFRC5.
        /// </summary>
        public const string RCDFRC5 = "RCDFRC5";

        /// <summary>
        /// RCFSCID.
        /// </summary>
        public const string RCFSCID = "RCFSCID";

        /// <summary>
        /// RCDFRCNAME.
        /// </summary>
        public const string RCDFRCNAME = "RCDFRCNAME";

        /// <summary>
        /// RCDFRCDESC.
        /// </summary>
        public const string RCDFRCDESC = "RCDFRCDESC";

        /// <summary>
        /// RCDFSTDT.
        /// </summary>
        public const string RCDFSTDT = "RCDFSTDT";

        /// <summary>
        /// RCDFENDT.
        /// </summary>
        public const string RCDFENDT = "RCDFENDT";

        /// <summary>
        /// RCDFRDID.
        /// </summary>
        public const string RCDFRDID = "RCDFRDID";

        /// <summary>
        /// RCREDENM.
        /// </summary>
        public const string RCREDENM = "RCREDENM";

        /// <summary>
        /// RCDFLNID.
        /// </summary>
        public const string RCDFLNID = "RCDFLNID";

        /// <summary>
        /// RCDFLNNA.
        /// </summary>
        public const string RCDFLNNA = "RCDFLNNA";

        /// <summary>
        /// RCLNDSID.
        /// </summary>
        public const string RCLNDSID = "RCLNDSID";

        /// <summary>
        /// RCLNDSNA.
        /// </summary>
        public const string RCLNDSNA = "RCLNDSNA";

        /// <summary>
        /// RCURCD.
        /// </summary>
        public const string RCURCD = "RCURCD";

        /// <summary>
        /// RCURDT.
        /// </summary>
        public const string RCURDT = "RCURDT";

        /// <summary>
        /// RCURAT.
        /// </summary>
        public const string RCURAT = "RCURAT";

        /// <summary>
        /// RCURAB.
        /// </summary>
        public const string RCURAB = "RCURAB";

        /// <summary>
        /// RCURRF.
        /// </summary>
        public const string RCURRF = "RCURRF";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCMKEY.
        /// </summary>
        public const string RCMKEY = "RCMKEY";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCUUPMJ.
        /// </summary>
        public const string RCUUPMJ = "RCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF34R011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCDFRCID", "RCDFRCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RCDFRC5", "RCDFRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RCFSCID", "RCFSCID", JdeDataType.Numeric),
        new JdeField("RCDFRCNAME", "RCDFRCNAME", JdeDataType.String, 60),
        new JdeField("RCDFRCDESC", "RCDFRCDESC", JdeDataType.String, 60),
        new JdeField("RCDFSTDT", "RCDFSTDT", JdeDataType.Numeric),
        new JdeField("RCDFENDT", "RCDFENDT", JdeDataType.Numeric),
        new JdeField("RCDFRDID", "RCDFRDID", JdeDataType.Numeric),
        new JdeField("RCREDENM", "RCREDENM", JdeDataType.String, 50),
        new JdeField("RCDFLNID", "RCDFLNID", JdeDataType.Numeric),
        new JdeField("RCDFLNNA", "RCDFLNNA", JdeDataType.String, 60),
        new JdeField("RCLNDSID", "RCLNDSID", JdeDataType.Numeric),
        new JdeField("RCLNDSNA", "RCLNDSNA", JdeDataType.String, 60),
        new JdeField("RCURCD", "RCURCD", JdeDataType.String, 4),
        new JdeField("RCURDT", "RCURDT", JdeDataType.Numeric),
        new JdeField("RCURAT", "RCURAT", JdeDataType.Numeric),
        new JdeField("RCURAB", "RCURAB", JdeDataType.Numeric),
        new JdeField("RCURRF", "RCURRF", JdeDataType.String, 30),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCMKEY", "RCMKEY", JdeDataType.String, 30),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCUUPMJ", "RCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34R011_0", "Primary Key on RCDFRCID, RCDFRC5", new[] { "RCDFRCID", "RCDFRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34R011_2", "Unique Index on RCDFRCNAME, RCDFRC5, RCFSCID", new[] { "RCDFRCNAME", "RCDFRC5", "RCFSCID" }, isUnique: true),
        new JdeIndex("FF34R011_4", "Index on RCDFLNNA, RCLNDSNA, RCFSCID", new[] { "RCDFLNNA", "RCLNDSNA", "RCFSCID" }),
        new JdeIndex("FF34R011_5", "Index on RCREDENM", new[] { "RCREDENM" }),
        new JdeIndex("FF34R011_6", "Index on RCDFRCNAME, RCFSCID", new[] { "RCDFRCNAME", "RCFSCID" })
    };
}
