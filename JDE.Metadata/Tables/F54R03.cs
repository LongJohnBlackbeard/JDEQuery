using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R03 - .
/// </summary>
public class F54R03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LHLNTY.
        /// </summary>
        public const string LHLNTY = "LHLNTY";

        /// <summary>
        /// LHMCU.
        /// </summary>
        public const string LHMCU = "LHMCU";

        /// <summary>
        /// LHAN8.
        /// </summary>
        public const string LHAN8 = "LHAN8";

        /// <summary>
        /// LH54RANT.
        /// </summary>
        public const string LH54RANT = "LH54RANT";

        /// <summary>
        /// LH54RPM.
        /// </summary>
        public const string LH54RPM = "LH54RPM";

        /// <summary>
        /// LHUSER.
        /// </summary>
        public const string LHUSER = "LHUSER";

        /// <summary>
        /// LHPID.
        /// </summary>
        public const string LHPID = "LHPID";

        /// <summary>
        /// LHUPMJ.
        /// </summary>
        public const string LHUPMJ = "LHUPMJ";

        /// <summary>
        /// LHUPMT.
        /// </summary>
        public const string LHUPMT = "LHUPMT";

        /// <summary>
        /// LHJOBN.
        /// </summary>
        public const string LHJOBN = "LHJOBN";

        /// <summary>
        /// LHMKEY.
        /// </summary>
        public const string LHMKEY = "LHMKEY";

        /// <summary>
        /// LHURCD.
        /// </summary>
        public const string LHURCD = "LHURCD";

        /// <summary>
        /// LHURDT.
        /// </summary>
        public const string LHURDT = "LHURDT";

        /// <summary>
        /// LHURAT.
        /// </summary>
        public const string LHURAT = "LHURAT";

        /// <summary>
        /// LHURAB.
        /// </summary>
        public const string LHURAB = "LHURAB";

        /// <summary>
        /// LHURRF.
        /// </summary>
        public const string LHURRF = "LHURRF";

        /// <summary>
        /// LHENTJ.
        /// </summary>
        public const string LHENTJ = "LHENTJ";

        /// <summary>
        /// LHTORG.
        /// </summary>
        public const string LHTORG = "LHTORG";

        /// <summary>
        /// LHTENT.
        /// </summary>
        public const string LHTENT = "LHTENT";
    }

    /// <inheritdoc />
    public override string TableName => "F54R03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LHLNTY", "LHLNTY", JdeDataType.String, 4, true, true),
        new JdeField("LHMCU", "LHMCU", JdeDataType.String, 24, true, true),
        new JdeField("LHAN8", "LHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LH54RANT", "LH54RANT", JdeDataType.String, 2, true, true),
        new JdeField("LH54RPM", "LH54RPM", JdeDataType.String, 2),
        new JdeField("LHUSER", "LHUSER", JdeDataType.String, 20),
        new JdeField("LHPID", "LHPID", JdeDataType.String, 20),
        new JdeField("LHUPMJ", "LHUPMJ", JdeDataType.Numeric),
        new JdeField("LHUPMT", "LHUPMT", JdeDataType.Numeric),
        new JdeField("LHJOBN", "LHJOBN", JdeDataType.String, 20),
        new JdeField("LHMKEY", "LHMKEY", JdeDataType.String, 30),
        new JdeField("LHURCD", "LHURCD", JdeDataType.String, 4),
        new JdeField("LHURDT", "LHURDT", JdeDataType.Numeric),
        new JdeField("LHURAT", "LHURAT", JdeDataType.Numeric),
        new JdeField("LHURAB", "LHURAB", JdeDataType.Numeric),
        new JdeField("LHURRF", "LHURRF", JdeDataType.String, 30),
        new JdeField("LHENTJ", "LHENTJ", JdeDataType.Numeric),
        new JdeField("LHTORG", "LHTORG", JdeDataType.String, 20),
        new JdeField("LHTENT", "LHTENT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R03_0", "Primary Key on LHLNTY, LHMCU, LHAN8, LH54RANT", new[] { "LHLNTY", "LHMCU", "LHAN8", "LH54RANT" }, isUnique: true, isPrimaryKey: true)
    };
}
