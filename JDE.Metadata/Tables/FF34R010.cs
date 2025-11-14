using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34R010 - .
/// </summary>
public class FF34R010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMDFRDID.
        /// </summary>
        public const string RMDFRDID = "RMDFRDID";

        /// <summary>
        /// RMDFRD5.
        /// </summary>
        public const string RMDFRD5 = "RMDFRD5";

        /// <summary>
        /// RMDFLNID.
        /// </summary>
        public const string RMDFLNID = "RMDFLNID";

        /// <summary>
        /// RMDFLNNA.
        /// </summary>
        public const string RMDFLNNA = "RMDFLNNA";

        /// <summary>
        /// RMLNDSID.
        /// </summary>
        public const string RMLNDSID = "RMLNDSID";

        /// <summary>
        /// RMLNDSNA.
        /// </summary>
        public const string RMLNDSNA = "RMLNDSNA";

        /// <summary>
        /// RMFSCID.
        /// </summary>
        public const string RMFSCID = "RMFSCID";

        /// <summary>
        /// RMREDENM.
        /// </summary>
        public const string RMREDENM = "RMREDENM";

        /// <summary>
        /// RMREDEDC.
        /// </summary>
        public const string RMREDEDC = "RMREDEDC";

        /// <summary>
        /// RMCELLID.
        /// </summary>
        public const string RMCELLID = "RMCELLID";

        /// <summary>
        /// RMPROID.
        /// </summary>
        public const string RMPROID = "RMPROID";

        /// <summary>
        /// RMRDUTYP.
        /// </summary>
        public const string RMRDUTYP = "RMRDUTYP";

        /// <summary>
        /// RMDFRID.
        /// </summary>
        public const string RMDFRID = "RMDFRID";

        /// <summary>
        /// RMRNAME.
        /// </summary>
        public const string RMRNAME = "RMRNAME";

        /// <summary>
        /// RMDFRT.
        /// </summary>
        public const string RMDFRT = "RMDFRT";

        /// <summary>
        /// RMCURQTY.
        /// </summary>
        public const string RMCURQTY = "RMCURQTY";

        /// <summary>
        /// RMPRPCHR.
        /// </summary>
        public const string RMPRPCHR = "RMPRPCHR";

        /// <summary>
        /// RMMKEY.
        /// </summary>
        public const string RMMKEY = "RMMKEY";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMUUPMJ.
        /// </summary>
        public const string RMUUPMJ = "RMUUPMJ";

        /// <summary>
        /// RMURCD.
        /// </summary>
        public const string RMURCD = "RMURCD";

        /// <summary>
        /// RMURDT.
        /// </summary>
        public const string RMURDT = "RMURDT";

        /// <summary>
        /// RMURAT.
        /// </summary>
        public const string RMURAT = "RMURAT";

        /// <summary>
        /// RMURAB.
        /// </summary>
        public const string RMURAB = "RMURAB";

        /// <summary>
        /// RMURRF.
        /// </summary>
        public const string RMURRF = "RMURRF";

        /// <summary>
        /// RMSHFT.
        /// </summary>
        public const string RMSHFT = "RMSHFT";
    }

    /// <inheritdoc />
    public override string TableName => "FF34R010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMDFRDID", "RMDFRDID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMDFRD5", "RMDFRD5", JdeDataType.Numeric, null, true, true),
        new JdeField("RMDFLNID", "RMDFLNID", JdeDataType.Numeric),
        new JdeField("RMDFLNNA", "RMDFLNNA", JdeDataType.String, 60),
        new JdeField("RMLNDSID", "RMLNDSID", JdeDataType.Numeric),
        new JdeField("RMLNDSNA", "RMLNDSNA", JdeDataType.String, 60),
        new JdeField("RMFSCID", "RMFSCID", JdeDataType.Numeric),
        new JdeField("RMREDENM", "RMREDENM", JdeDataType.String, 50),
        new JdeField("RMREDEDC", "RMREDEDC", JdeDataType.String, 100),
        new JdeField("RMCELLID", "RMCELLID", JdeDataType.Numeric),
        new JdeField("RMPROID", "RMPROID", JdeDataType.Numeric),
        new JdeField("RMRDUTYP", "RMRDUTYP", JdeDataType.String, 6),
        new JdeField("RMDFRID", "RMDFRID", JdeDataType.Numeric),
        new JdeField("RMRNAME", "RMRNAME", JdeDataType.String, 50),
        new JdeField("RMDFRT", "RMDFRT", JdeDataType.String, 4),
        new JdeField("RMCURQTY", "RMCURQTY", JdeDataType.Numeric),
        new JdeField("RMPRPCHR", "RMPRPCHR", JdeDataType.Numeric),
        new JdeField("RMMKEY", "RMMKEY", JdeDataType.String, 30),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMUUPMJ", "RMUUPMJ", JdeDataType.Date),
        new JdeField("RMURCD", "RMURCD", JdeDataType.String, 4),
        new JdeField("RMURDT", "RMURDT", JdeDataType.Numeric),
        new JdeField("RMURAT", "RMURAT", JdeDataType.Numeric),
        new JdeField("RMURAB", "RMURAB", JdeDataType.Numeric),
        new JdeField("RMURRF", "RMURRF", JdeDataType.String, 30),
        new JdeField("RMSHFT", "RMSHFT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34R010_0", "Primary Key on RMDFRDID, RMDFRD5", new[] { "RMDFRDID", "RMDFRD5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34R010_4", "Unique Index on RMFSCID, RMREDENM, RMDFRD5", new[] { "RMFSCID", "RMREDENM", "RMDFRD5" }, isUnique: true)
    };
}
