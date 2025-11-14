using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B02 - .
/// </summary>
public class F31B02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STSFNB.
        /// </summary>
        public const string STSFNB = "STSFNB";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STALPH.
        /// </summary>
        public const string STALPH = "STALPH";

        /// <summary>
        /// STANAG.
        /// </summary>
        public const string STANAG = "STANAG";

        /// <summary>
        /// STSRNM.
        /// </summary>
        public const string STSRNM = "STSRNM";

        /// <summary>
        /// STGNNM.
        /// </summary>
        public const string STGNNM = "STGNNM";

        /// <summary>
        /// STOTNM.
        /// </summary>
        public const string STOTNM = "STOTNM";

        /// <summary>
        /// STEMTY.
        /// </summary>
        public const string STEMTY = "STEMTY";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STWAID.
        /// </summary>
        public const string STWAID = "STWAID";

        /// <summary>
        /// STFMDT.
        /// </summary>
        public const string STFMDT = "STFMDT";

        /// <summary>
        /// STTODT.
        /// </summary>
        public const string STTODT = "STTODT";

        /// <summary>
        /// STWKSH.
        /// </summary>
        public const string STWKSH = "STWKSH";

        /// <summary>
        /// STJBTT.
        /// </summary>
        public const string STJBTT = "STJBTT";

        /// <summary>
        /// STCSPH.
        /// </summary>
        public const string STCSPH = "STCSPH";

        /// <summary>
        /// STSKGR.
        /// </summary>
        public const string STSKGR = "STSKGR";

        /// <summary>
        /// STWFTE.
        /// </summary>
        public const string STWFTE = "STWFTE";

        /// <summary>
        /// STSFC1.
        /// </summary>
        public const string STSFC1 = "STSFC1";

        /// <summary>
        /// STSFC2.
        /// </summary>
        public const string STSFC2 = "STSFC2";

        /// <summary>
        /// STSFC3.
        /// </summary>
        public const string STSFC3 = "STSFC3";

        /// <summary>
        /// STSSTU.
        /// </summary>
        public const string STSSTU = "STSSTU";

        /// <summary>
        /// STGECM.
        /// </summary>
        public const string STGECM = "STGECM";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STURCD.
        /// </summary>
        public const string STURCD = "STURCD";

        /// <summary>
        /// STURDT.
        /// </summary>
        public const string STURDT = "STURDT";

        /// <summary>
        /// STURAT.
        /// </summary>
        public const string STURAT = "STURAT";

        /// <summary>
        /// STURRF.
        /// </summary>
        public const string STURRF = "STURRF";

        /// <summary>
        /// STURAB.
        /// </summary>
        public const string STURAB = "STURAB";

        /// <summary>
        /// STWCG.
        /// </summary>
        public const string STWCG = "STWCG";

        /// <summary>
        /// STWRF.
        /// </summary>
        public const string STWRF = "STWRF";

        /// <summary>
        /// STWCD.
        /// </summary>
        public const string STWCD = "STWCD";

        /// <summary>
        /// STWAB.
        /// </summary>
        public const string STWAB = "STWAB";

        /// <summary>
        /// STWNUM.
        /// </summary>
        public const string STWNUM = "STWNUM";

        /// <summary>
        /// STWMDT.
        /// </summary>
        public const string STWMDT = "STWMDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STSFNB", "STSFNB", JdeDataType.Numeric, null, true, true),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric),
        new JdeField("STALPH", "STALPH", JdeDataType.String, 80),
        new JdeField("STANAG", "STANAG", JdeDataType.Numeric),
        new JdeField("STSRNM", "STSRNM", JdeDataType.String, 50),
        new JdeField("STGNNM", "STGNNM", JdeDataType.String, 50),
        new JdeField("STOTNM", "STOTNM", JdeDataType.String, 40),
        new JdeField("STEMTY", "STEMTY", JdeDataType.String, 6),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24),
        new JdeField("STWAID", "STWAID", JdeDataType.String, 16),
        new JdeField("STFMDT", "STFMDT", JdeDataType.Numeric),
        new JdeField("STTODT", "STTODT", JdeDataType.Numeric),
        new JdeField("STWKSH", "STWKSH", JdeDataType.String, 2),
        new JdeField("STJBTT", "STJBTT", JdeDataType.String, 6),
        new JdeField("STCSPH", "STCSPH", JdeDataType.Numeric),
        new JdeField("STSKGR", "STSKGR", JdeDataType.String, 2),
        new JdeField("STWFTE", "STWFTE", JdeDataType.Numeric),
        new JdeField("STSFC1", "STSFC1", JdeDataType.String, 6),
        new JdeField("STSFC2", "STSFC2", JdeDataType.String, 6),
        new JdeField("STSFC3", "STSFC3", JdeDataType.String, 6),
        new JdeField("STSSTU", "STSSTU", JdeDataType.String, 2),
        new JdeField("STGECM", "STGECM", JdeDataType.String, 80),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STURCD", "STURCD", JdeDataType.String, 4),
        new JdeField("STURDT", "STURDT", JdeDataType.Numeric),
        new JdeField("STURAT", "STURAT", JdeDataType.Numeric),
        new JdeField("STURRF", "STURRF", JdeDataType.String, 30),
        new JdeField("STURAB", "STURAB", JdeDataType.Numeric),
        new JdeField("STWCG", "STWCG", JdeDataType.String, 24),
        new JdeField("STWRF", "STWRF", JdeDataType.String, 60),
        new JdeField("STWCD", "STWCD", JdeDataType.String, 6),
        new JdeField("STWAB", "STWAB", JdeDataType.Numeric),
        new JdeField("STWNUM", "STWNUM", JdeDataType.Numeric),
        new JdeField("STWMDT", "STWMDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B02_0", "Primary Key on STSFNB", new[] { "STSFNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B02_2", "Index on STAN8, STMCU", new[] { "STAN8", "STMCU" })
    };
}
