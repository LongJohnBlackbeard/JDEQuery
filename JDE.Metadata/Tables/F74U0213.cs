using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0213 - .
/// </summary>
public class F74U0213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWLNID.
        /// </summary>
        public const string PWLNID = "PWLNID";

        /// <summary>
        /// PWDOCO.
        /// </summary>
        public const string PWDOCO = "PWDOCO";

        /// <summary>
        /// PW74UWAPL.
        /// </summary>
        public const string PW74UWAPL = "PW74UWAPL";

        /// <summary>
        /// PW74UACPL.
        /// </summary>
        public const string PW74UACPL = "PW74UACPL";

        /// <summary>
        /// PW74UGENT.
        /// </summary>
        public const string PW74UGENT = "PW74UGENT";

        /// <summary>
        /// PW74UGLC.
        /// </summary>
        public const string PW74UGLC = "PW74UGLC";

        /// <summary>
        /// PWLSVR.
        /// </summary>
        public const string PWLSVR = "PWLSVR";

        /// <summary>
        /// PWTXA1.
        /// </summary>
        public const string PWTXA1 = "PWTXA1";

        /// <summary>
        /// PWEXR1.
        /// </summary>
        public const string PWEXR1 = "PWEXR1";

        /// <summary>
        /// PW74UCRCD.
        /// </summary>
        public const string PW74UCRCD = "PW74UCRCD";

        /// <summary>
        /// PWCRR.
        /// </summary>
        public const string PWCRR = "PWCRR";

        /// <summary>
        /// PW74UFROM.
        /// </summary>
        public const string PW74UFROM = "PW74UFROM";

        /// <summary>
        /// PW74UGJD.
        /// </summary>
        public const string PW74UGJD = "PW74UGJD";

        /// <summary>
        /// PW74UGAMT.
        /// </summary>
        public const string PW74UGAMT = "PW74UGAMT";

        /// <summary>
        /// PW74USTA.
        /// </summary>
        public const string PW74USTA = "PW74USTA";

        /// <summary>
        /// PW74UCPLD.
        /// </summary>
        public const string PW74UCPLD = "PW74UCPLD";

        /// <summary>
        /// PW74UTIMC.
        /// </summary>
        public const string PW74UTIMC = "PW74UTIMC";

        /// <summary>
        /// PWKCO.
        /// </summary>
        public const string PWKCO = "PWKCO";

        /// <summary>
        /// PWDOC.
        /// </summary>
        public const string PWDOC = "PWDOC";

        /// <summary>
        /// PWDCT.
        /// </summary>
        public const string PWDCT = "PWDCT";

        /// <summary>
        /// PWDGJ.
        /// </summary>
        public const string PWDGJ = "PWDGJ";

        /// <summary>
        /// PW74UCANR.
        /// </summary>
        public const string PW74UCANR = "PW74UCANR";

        /// <summary>
        /// PWFY.
        /// </summary>
        public const string PWFY = "PWFY";

        /// <summary>
        /// PWCTRY.
        /// </summary>
        public const string PWCTRY = "PWCTRY";

        /// <summary>
        /// PWURCD.
        /// </summary>
        public const string PWURCD = "PWURCD";

        /// <summary>
        /// PWURAT.
        /// </summary>
        public const string PWURAT = "PWURAT";

        /// <summary>
        /// PWURAB.
        /// </summary>
        public const string PWURAB = "PWURAB";

        /// <summary>
        /// PWURRF.
        /// </summary>
        public const string PWURRF = "PWURRF";

        /// <summary>
        /// PWUSER.
        /// </summary>
        public const string PWUSER = "PWUSER";

        /// <summary>
        /// PWPID.
        /// </summary>
        public const string PWPID = "PWPID";

        /// <summary>
        /// PWUPMJ.
        /// </summary>
        public const string PWUPMJ = "PWUPMJ";

        /// <summary>
        /// PWUPMT.
        /// </summary>
        public const string PWUPMT = "PWUPMT";

        /// <summary>
        /// PWJOBN.
        /// </summary>
        public const string PWJOBN = "PWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWLNID", "PWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWDOCO", "PWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PW74UWAPL", "PW74UWAPL", JdeDataType.Numeric, null, true, true),
        new JdeField("PW74UACPL", "PW74UACPL", JdeDataType.Numeric, null, true, true),
        new JdeField("PW74UGENT", "PW74UGENT", JdeDataType.String, 2),
        new JdeField("PW74UGLC", "PW74UGLC", JdeDataType.String, 8),
        new JdeField("PWLSVR", "PWLSVR", JdeDataType.Numeric),
        new JdeField("PWTXA1", "PWTXA1", JdeDataType.String, 20),
        new JdeField("PWEXR1", "PWEXR1", JdeDataType.String, 4),
        new JdeField("PW74UCRCD", "PW74UCRCD", JdeDataType.String, 6),
        new JdeField("PWCRR", "PWCRR", JdeDataType.Numeric),
        new JdeField("PW74UFROM", "PW74UFROM", JdeDataType.Numeric),
        new JdeField("PW74UGJD", "PW74UGJD", JdeDataType.Numeric),
        new JdeField("PW74UGAMT", "PW74UGAMT", JdeDataType.Numeric),
        new JdeField("PW74USTA", "PW74USTA", JdeDataType.String, 2),
        new JdeField("PW74UCPLD", "PW74UCPLD", JdeDataType.Numeric),
        new JdeField("PW74UTIMC", "PW74UTIMC", JdeDataType.Numeric),
        new JdeField("PWKCO", "PWKCO", JdeDataType.String, 10),
        new JdeField("PWDOC", "PWDOC", JdeDataType.Numeric),
        new JdeField("PWDCT", "PWDCT", JdeDataType.String, 4),
        new JdeField("PWDGJ", "PWDGJ", JdeDataType.Numeric),
        new JdeField("PW74UCANR", "PW74UCANR", JdeDataType.String, 6),
        new JdeField("PWFY", "PWFY", JdeDataType.Numeric),
        new JdeField("PWCTRY", "PWCTRY", JdeDataType.Numeric),
        new JdeField("PWURCD", "PWURCD", JdeDataType.String, 4),
        new JdeField("PWURAT", "PWURAT", JdeDataType.Numeric),
        new JdeField("PWURAB", "PWURAB", JdeDataType.Numeric),
        new JdeField("PWURRF", "PWURRF", JdeDataType.String, 30),
        new JdeField("PWUSER", "PWUSER", JdeDataType.String, 20),
        new JdeField("PWPID", "PWPID", JdeDataType.String, 20),
        new JdeField("PWUPMJ", "PWUPMJ", JdeDataType.Numeric),
        new JdeField("PWUPMT", "PWUPMT", JdeDataType.Numeric),
        new JdeField("PWJOBN", "PWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0213_0", "Primary Key on PWLNID, PWDOCO, PW74UWAPL, PW74UACPL", new[] { "PWLNID", "PWDOCO", "PW74UWAPL", "PW74UACPL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0213_2", "Index on SYS_NC00034$, SYS_NC00035$, SYS_NC00036$", new[] { "SYS_NC00034$", "SYS_NC00035$", "SYS_NC00036$" })
    };
}
