using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079430 - .
/// </summary>
public class F079430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWDWK.
        /// </summary>
        public const string PWDWK = "PWDWK";

        /// <summary>
        /// PWPRTR.
        /// </summary>
        public const string PWPRTR = "PWPRTR";

        /// <summary>
        /// PWCKCN.
        /// </summary>
        public const string PWCKCN = "PWCKCN";

        /// <summary>
        /// PWPAYD.
        /// </summary>
        public const string PWPAYD = "PWPAYD";

        /// <summary>
        /// PWPWPF.
        /// </summary>
        public const string PWPWPF = "PWPWPF";

        /// <summary>
        /// PWPWPDBA.
        /// </summary>
        public const string PWPWPDBA = "PWPWPDBA";

        /// <summary>
        /// PWPWCF.
        /// </summary>
        public const string PWPWCF = "PWPWCF";

        /// <summary>
        /// PWPWCM.
        /// </summary>
        public const string PWPWCM = "PWPWCM";

        /// <summary>
        /// PWPWCR.
        /// </summary>
        public const string PWPWCR = "PWPWCR";

        /// <summary>
        /// PWPWAJCD.
        /// </summary>
        public const string PWPWAJCD = "PWPWAJCD";

        /// <summary>
        /// PWPWAAMT.
        /// </summary>
        public const string PWPWAAMT = "PWPWAAMT";

        /// <summary>
        /// PWPWTRNO.
        /// </summary>
        public const string PWPWTRNO = "PWPWTRNO";

        /// <summary>
        /// PWPWSMMF.
        /// </summary>
        public const string PWPWSMMF = "PWPWSMMF";

        /// <summary>
        /// PWPWJHRT.
        /// </summary>
        public const string PWPWJHRT = "PWPWJHRT";

        /// <summary>
        /// PWPWJFRT.
        /// </summary>
        public const string PWPWJFRT = "PWPWJFRT";

        /// <summary>
        /// PWBHRT.
        /// </summary>
        public const string PWBHRT = "PWBHRT";

        /// <summary>
        /// PWPWEFRT.
        /// </summary>
        public const string PWPWEFRT = "PWPWEFRT";

        /// <summary>
        /// PWCO.
        /// </summary>
        public const string PWCO = "PWCO";

        /// <summary>
        /// PWPWCH01.
        /// </summary>
        public const string PWPWCH01 = "PWPWCH01";

        /// <summary>
        /// PWPWCH02.
        /// </summary>
        public const string PWPWCH02 = "PWPWCH02";

        /// <summary>
        /// PWPWCH03.
        /// </summary>
        public const string PWPWCH03 = "PWPWCH03";

        /// <summary>
        /// PWPWCH04.
        /// </summary>
        public const string PWPWCH04 = "PWPWCH04";

        /// <summary>
        /// PWPWJD01.
        /// </summary>
        public const string PWPWJD01 = "PWPWJD01";

        /// <summary>
        /// PWPWJD02.
        /// </summary>
        public const string PWPWJD02 = "PWPWJD02";

        /// <summary>
        /// PWPWJD03.
        /// </summary>
        public const string PWPWJD03 = "PWPWJD03";

        /// <summary>
        /// PWPWJD04.
        /// </summary>
        public const string PWPWJD04 = "PWPWJD04";

        /// <summary>
        /// PWPWST01.
        /// </summary>
        public const string PWPWST01 = "PWPWST01";

        /// <summary>
        /// PWPWST02.
        /// </summary>
        public const string PWPWST02 = "PWPWST02";

        /// <summary>
        /// PWPWST03.
        /// </summary>
        public const string PWPWST03 = "PWPWST03";

        /// <summary>
        /// PWPWST04.
        /// </summary>
        public const string PWPWST04 = "PWPWST04";

        /// <summary>
        /// PWPWMN01.
        /// </summary>
        public const string PWPWMN01 = "PWPWMN01";

        /// <summary>
        /// PWPWMN02.
        /// </summary>
        public const string PWPWMN02 = "PWPWMN02";

        /// <summary>
        /// PWPWMN03.
        /// </summary>
        public const string PWPWMN03 = "PWPWMN03";

        /// <summary>
        /// PWPWMN04.
        /// </summary>
        public const string PWPWMN04 = "PWPWMN04";

        /// <summary>
        /// PWUSER.
        /// </summary>
        public const string PWUSER = "PWUSER";

        /// <summary>
        /// PWPID.
        /// </summary>
        public const string PWPID = "PWPID";

        /// <summary>
        /// PWJOBN.
        /// </summary>
        public const string PWJOBN = "PWJOBN";

        /// <summary>
        /// PWUPMJ.
        /// </summary>
        public const string PWUPMJ = "PWUPMJ";

        /// <summary>
        /// PWUPMT.
        /// </summary>
        public const string PWUPMT = "PWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F079430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PWDWK", "PWDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("PWPRTR", "PWPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("PWCKCN", "PWCKCN", JdeDataType.Numeric),
        new JdeField("PWPAYD", "PWPAYD", JdeDataType.String, 20),
        new JdeField("PWPWPF", "PWPWPF", JdeDataType.String, 2),
        new JdeField("PWPWPDBA", "PWPWPDBA", JdeDataType.Numeric),
        new JdeField("PWPWCF", "PWPWCF", JdeDataType.String, 2),
        new JdeField("PWPWCM", "PWPWCM", JdeDataType.String, 4),
        new JdeField("PWPWCR", "PWPWCR", JdeDataType.String, 2),
        new JdeField("PWPWAJCD", "PWPWAJCD", JdeDataType.Numeric),
        new JdeField("PWPWAAMT", "PWPWAAMT", JdeDataType.Numeric),
        new JdeField("PWPWTRNO", "PWPWTRNO", JdeDataType.Numeric),
        new JdeField("PWPWSMMF", "PWPWSMMF", JdeDataType.String, 2),
        new JdeField("PWPWJHRT", "PWPWJHRT", JdeDataType.Numeric),
        new JdeField("PWPWJFRT", "PWPWJFRT", JdeDataType.Numeric),
        new JdeField("PWBHRT", "PWBHRT", JdeDataType.Numeric),
        new JdeField("PWPWEFRT", "PWPWEFRT", JdeDataType.Numeric),
        new JdeField("PWCO", "PWCO", JdeDataType.String, 10),
        new JdeField("PWPWCH01", "PWPWCH01", JdeDataType.String, 2),
        new JdeField("PWPWCH02", "PWPWCH02", JdeDataType.String, 2),
        new JdeField("PWPWCH03", "PWPWCH03", JdeDataType.String, 2),
        new JdeField("PWPWCH04", "PWPWCH04", JdeDataType.String, 2),
        new JdeField("PWPWJD01", "PWPWJD01", JdeDataType.Numeric),
        new JdeField("PWPWJD02", "PWPWJD02", JdeDataType.Numeric),
        new JdeField("PWPWJD03", "PWPWJD03", JdeDataType.Numeric),
        new JdeField("PWPWJD04", "PWPWJD04", JdeDataType.Numeric),
        new JdeField("PWPWST01", "PWPWST01", JdeDataType.String, 40),
        new JdeField("PWPWST02", "PWPWST02", JdeDataType.String, 40),
        new JdeField("PWPWST03", "PWPWST03", JdeDataType.String, 80),
        new JdeField("PWPWST04", "PWPWST04", JdeDataType.String, 80),
        new JdeField("PWPWMN01", "PWPWMN01", JdeDataType.Numeric),
        new JdeField("PWPWMN02", "PWPWMN02", JdeDataType.Numeric),
        new JdeField("PWPWMN03", "PWPWMN03", JdeDataType.Numeric),
        new JdeField("PWPWMN04", "PWPWMN04", JdeDataType.Numeric),
        new JdeField("PWUSER", "PWUSER", JdeDataType.String, 20),
        new JdeField("PWPID", "PWPID", JdeDataType.String, 20),
        new JdeField("PWJOBN", "PWJOBN", JdeDataType.String, 20),
        new JdeField("PWUPMJ", "PWUPMJ", JdeDataType.Numeric),
        new JdeField("PWUPMT", "PWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079430_0", "Primary Key on PWAN8, PWDWK, PWPRTR", new[] { "PWAN8", "PWDWK", "PWPRTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F079430_2", "Index on PWAN8, PWCKCN", new[] { "PWAN8", "PWCKCN" })
    };
}
