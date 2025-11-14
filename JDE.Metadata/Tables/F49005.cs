using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49005 - .
/// </summary>
public class F49005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TGCARS.
        /// </summary>
        public const string TGCARS = "TGCARS";

        /// <summary>
        /// TGMOT.
        /// </summary>
        public const string TGMOT = "TGMOT";

        /// <summary>
        /// TGDCCD.
        /// </summary>
        public const string TGDCCD = "TGDCCD";

        /// <summary>
        /// TGNTSG.
        /// </summary>
        public const string TGNTSG = "TGNTSG";

        /// <summary>
        /// TGLGTN.
        /// </summary>
        public const string TGLGTN = "TGLGTN";

        /// <summary>
        /// TGURCD.
        /// </summary>
        public const string TGURCD = "TGURCD";

        /// <summary>
        /// TGURDT.
        /// </summary>
        public const string TGURDT = "TGURDT";

        /// <summary>
        /// TGURAT.
        /// </summary>
        public const string TGURAT = "TGURAT";

        /// <summary>
        /// TGURAB.
        /// </summary>
        public const string TGURAB = "TGURAB";

        /// <summary>
        /// TGURRF.
        /// </summary>
        public const string TGURRF = "TGURRF";

        /// <summary>
        /// TGUSER.
        /// </summary>
        public const string TGUSER = "TGUSER";

        /// <summary>
        /// TGPID.
        /// </summary>
        public const string TGPID = "TGPID";

        /// <summary>
        /// TGJOBN.
        /// </summary>
        public const string TGJOBN = "TGJOBN";

        /// <summary>
        /// TGUPMJ.
        /// </summary>
        public const string TGUPMJ = "TGUPMJ";

        /// <summary>
        /// TGTDAY.
        /// </summary>
        public const string TGTDAY = "TGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TGCARS", "TGCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("TGMOT", "TGMOT", JdeDataType.String, 6, true, true),
        new JdeField("TGDCCD", "TGDCCD", JdeDataType.String, 8, true, true),
        new JdeField("TGNTSG", "TGNTSG", JdeDataType.Numeric),
        new JdeField("TGLGTN", "TGLGTN", JdeDataType.Numeric),
        new JdeField("TGURCD", "TGURCD", JdeDataType.String, 4),
        new JdeField("TGURDT", "TGURDT", JdeDataType.Numeric),
        new JdeField("TGURAT", "TGURAT", JdeDataType.Numeric),
        new JdeField("TGURAB", "TGURAB", JdeDataType.Numeric),
        new JdeField("TGURRF", "TGURRF", JdeDataType.String, 30),
        new JdeField("TGUSER", "TGUSER", JdeDataType.String, 20),
        new JdeField("TGPID", "TGPID", JdeDataType.String, 20),
        new JdeField("TGJOBN", "TGJOBN", JdeDataType.String, 20),
        new JdeField("TGUPMJ", "TGUPMJ", JdeDataType.Numeric),
        new JdeField("TGTDAY", "TGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49005_0", "Primary Key on TGCARS, TGMOT, TGDCCD", new[] { "TGCARS", "TGMOT", "TGDCCD" }, isUnique: true, isPrimaryKey: true)
    };
}
