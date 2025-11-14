using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B45 - .
/// </summary>
public class F31B45 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATWTMPID.
        /// </summary>
        public const string ATWTMPID = "ATWTMPID";

        /// <summary>
        /// ATWTMPNM.
        /// </summary>
        public const string ATWTMPNM = "ATWTMPNM";

        /// <summary>
        /// ATWTMPDS.
        /// </summary>
        public const string ATWTMPDS = "ATWTMPDS";

        /// <summary>
        /// ATWTMPST.
        /// </summary>
        public const string ATWTMPST = "ATWTMPST";

        /// <summary>
        /// ATWTMPC1.
        /// </summary>
        public const string ATWTMPC1 = "ATWTMPC1";

        /// <summary>
        /// ATWTMPC2.
        /// </summary>
        public const string ATWTMPC2 = "ATWTMPC2";

        /// <summary>
        /// ATWTMPC3.
        /// </summary>
        public const string ATWTMPC3 = "ATWTMPC3";

        /// <summary>
        /// ATWTMPC4.
        /// </summary>
        public const string ATWTMPC4 = "ATWTMPC4";

        /// <summary>
        /// ATWTMPC5.
        /// </summary>
        public const string ATWTMPC5 = "ATWTMPC5";

        /// <summary>
        /// ATMCU.
        /// </summary>
        public const string ATMCU = "ATMCU";

        /// <summary>
        /// ATITM.
        /// </summary>
        public const string ATITM = "ATITM";

        /// <summary>
        /// ATADDQTY.
        /// </summary>
        public const string ATADDQTY = "ATADDQTY";

        /// <summary>
        /// ATADTUOM.
        /// </summary>
        public const string ATADTUOM = "ATADTUOM";

        /// <summary>
        /// ATARQTY.
        /// </summary>
        public const string ATARQTY = "ATARQTY";

        /// <summary>
        /// ATADRUM.
        /// </summary>
        public const string ATADRUM = "ATADRUM";

        /// <summary>
        /// ATLOCN.
        /// </summary>
        public const string ATLOCN = "ATLOCN";

        /// <summary>
        /// ATLOTN.
        /// </summary>
        public const string ATLOTN = "ATLOTN";

        /// <summary>
        /// ATADMT.
        /// </summary>
        public const string ATADMT = "ATADMT";

        /// <summary>
        /// ATURAB.
        /// </summary>
        public const string ATURAB = "ATURAB";

        /// <summary>
        /// ATURAT.
        /// </summary>
        public const string ATURAT = "ATURAT";

        /// <summary>
        /// ATURCD.
        /// </summary>
        public const string ATURCD = "ATURCD";

        /// <summary>
        /// ATURDT.
        /// </summary>
        public const string ATURDT = "ATURDT";

        /// <summary>
        /// ATURRF.
        /// </summary>
        public const string ATURRF = "ATURRF";

        /// <summary>
        /// ATWAB.
        /// </summary>
        public const string ATWAB = "ATWAB";

        /// <summary>
        /// ATWCD.
        /// </summary>
        public const string ATWCD = "ATWCD";

        /// <summary>
        /// ATWMDT.
        /// </summary>
        public const string ATWMDT = "ATWMDT";

        /// <summary>
        /// ATWNUM.
        /// </summary>
        public const string ATWNUM = "ATWNUM";

        /// <summary>
        /// ATWRF.
        /// </summary>
        public const string ATWRF = "ATWRF";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATMKEY.
        /// </summary>
        public const string ATMKEY = "ATMKEY";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATWCRTR.
        /// </summary>
        public const string ATWCRTR = "ATWCRTR";
    }

    /// <inheritdoc />
    public override string TableName => "F31B45";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATWTMPID", "ATWTMPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ATWTMPNM", "ATWTMPNM", JdeDataType.String, 60),
        new JdeField("ATWTMPDS", "ATWTMPDS", JdeDataType.String, 60),
        new JdeField("ATWTMPST", "ATWTMPST", JdeDataType.String, 2),
        new JdeField("ATWTMPC1", "ATWTMPC1", JdeDataType.String, 20),
        new JdeField("ATWTMPC2", "ATWTMPC2", JdeDataType.String, 20),
        new JdeField("ATWTMPC3", "ATWTMPC3", JdeDataType.String, 20),
        new JdeField("ATWTMPC4", "ATWTMPC4", JdeDataType.String, 20),
        new JdeField("ATWTMPC5", "ATWTMPC5", JdeDataType.String, 20),
        new JdeField("ATMCU", "ATMCU", JdeDataType.String, 24),
        new JdeField("ATITM", "ATITM", JdeDataType.Numeric),
        new JdeField("ATADDQTY", "ATADDQTY", JdeDataType.Numeric),
        new JdeField("ATADTUOM", "ATADTUOM", JdeDataType.String, 4),
        new JdeField("ATARQTY", "ATARQTY", JdeDataType.Numeric),
        new JdeField("ATADRUM", "ATADRUM", JdeDataType.String, 4),
        new JdeField("ATLOCN", "ATLOCN", JdeDataType.String, 40),
        new JdeField("ATLOTN", "ATLOTN", JdeDataType.String, 60),
        new JdeField("ATADMT", "ATADMT", JdeDataType.String, 2),
        new JdeField("ATURAB", "ATURAB", JdeDataType.Numeric),
        new JdeField("ATURAT", "ATURAT", JdeDataType.Numeric),
        new JdeField("ATURCD", "ATURCD", JdeDataType.String, 4),
        new JdeField("ATURDT", "ATURDT", JdeDataType.Numeric),
        new JdeField("ATURRF", "ATURRF", JdeDataType.String, 30),
        new JdeField("ATWAB", "ATWAB", JdeDataType.Numeric),
        new JdeField("ATWCD", "ATWCD", JdeDataType.String, 6),
        new JdeField("ATWMDT", "ATWMDT", JdeDataType.Numeric),
        new JdeField("ATWNUM", "ATWNUM", JdeDataType.Numeric),
        new JdeField("ATWRF", "ATWRF", JdeDataType.String, 60),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATMKEY", "ATMKEY", JdeDataType.String, 30),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATWCRTR", "ATWCRTR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B45_0", "Primary Key on ATWTMPID", new[] { "ATWTMPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B45_2", "Index on ATWTMPNM", new[] { "ATWTMPNM" })
    };
}
