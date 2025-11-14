using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46011 - .
/// </summary>
public class F46011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IQMCU.
        /// </summary>
        public const string IQMCU = "IQMCU";

        /// <summary>
        /// IQPRP6.
        /// </summary>
        public const string IQPRP6 = "IQPRP6";

        /// <summary>
        /// IQITM.
        /// </summary>
        public const string IQITM = "IQITM";

        /// <summary>
        /// IQUOM.
        /// </summary>
        public const string IQUOM = "IQUOM";

        /// <summary>
        /// IQGWID.
        /// </summary>
        public const string IQGWID = "IQGWID";

        /// <summary>
        /// IQGDEP.
        /// </summary>
        public const string IQGDEP = "IQGDEP";

        /// <summary>
        /// IQGHET.
        /// </summary>
        public const string IQGHET = "IQGHET";

        /// <summary>
        /// IQWIUM.
        /// </summary>
        public const string IQWIUM = "IQWIUM";

        /// <summary>
        /// IQGCUB.
        /// </summary>
        public const string IQGCUB = "IQGCUB";

        /// <summary>
        /// IQVUMD.
        /// </summary>
        public const string IQVUMD = "IQVUMD";

        /// <summary>
        /// IQGWEI.
        /// </summary>
        public const string IQGWEI = "IQGWEI";

        /// <summary>
        /// IQUWUM.
        /// </summary>
        public const string IQUWUM = "IQUWUM";

        /// <summary>
        /// IQDMTH.
        /// </summary>
        public const string IQDMTH = "IQDMTH";

        /// <summary>
        /// IQCRMT.
        /// </summary>
        public const string IQCRMT = "IQCRMT";

        /// <summary>
        /// IQEQUS.
        /// </summary>
        public const string IQEQUS = "IQEQUS";

        /// <summary>
        /// IQAROT.
        /// </summary>
        public const string IQAROT = "IQAROT";

        /// <summary>
        /// IQABKD.
        /// </summary>
        public const string IQABKD = "IQABKD";

        /// <summary>
        /// IQAROL.
        /// </summary>
        public const string IQAROL = "IQAROL";

        /// <summary>
        /// IQSLIM.
        /// </summary>
        public const string IQSLIM = "IQSLIM";

        /// <summary>
        /// IQEQTY.
        /// </summary>
        public const string IQEQTY = "IQEQTY";

        /// <summary>
        /// IQRPCK.
        /// </summary>
        public const string IQRPCK = "IQRPCK";

        /// <summary>
        /// IQPACK.
        /// </summary>
        public const string IQPACK = "IQPACK";

        /// <summary>
        /// IQLIPL.
        /// </summary>
        public const string IQLIPL = "IQLIPL";

        /// <summary>
        /// IQPPTG.
        /// </summary>
        public const string IQPPTG = "IQPPTG";

        /// <summary>
        /// IQPKTG.
        /// </summary>
        public const string IQPKTG = "IQPKTG";

        /// <summary>
        /// IQPRTG.
        /// </summary>
        public const string IQPRTG = "IQPRTG";

        /// <summary>
        /// IQPTRA.
        /// </summary>
        public const string IQPTRA = "IQPTRA";

        /// <summary>
        /// IQKTRA.
        /// </summary>
        public const string IQKTRA = "IQKTRA";

        /// <summary>
        /// IQRTRA.
        /// </summary>
        public const string IQRTRA = "IQRTRA";

        /// <summary>
        /// IQUSER.
        /// </summary>
        public const string IQUSER = "IQUSER";

        /// <summary>
        /// IQPID.
        /// </summary>
        public const string IQPID = "IQPID";

        /// <summary>
        /// IQJOBN.
        /// </summary>
        public const string IQJOBN = "IQJOBN";

        /// <summary>
        /// IQUPMJ.
        /// </summary>
        public const string IQUPMJ = "IQUPMJ";

        /// <summary>
        /// IQTDAY.
        /// </summary>
        public const string IQTDAY = "IQTDAY";

        /// <summary>
        /// IQUCCU.
        /// </summary>
        public const string IQUCCU = "IQUCCU";

        /// <summary>
        /// IQPKBKD.
        /// </summary>
        public const string IQPKBKD = "IQPKBKD";

        /// <summary>
        /// IQIUOMFUC1.
        /// </summary>
        public const string IQIUOMFUC1 = "IQIUOMFUC1";

        /// <summary>
        /// IQIUOMFUC2.
        /// </summary>
        public const string IQIUOMFUC2 = "IQIUOMFUC2";

        /// <summary>
        /// IQIUOMFUS1.
        /// </summary>
        public const string IQIUOMFUS1 = "IQIUOMFUS1";

        /// <summary>
        /// IQIUOMFUS2.
        /// </summary>
        public const string IQIUOMFUS2 = "IQIUOMFUS2";

        /// <summary>
        /// IQIUOMFUN1.
        /// </summary>
        public const string IQIUOMFUN1 = "IQIUOMFUN1";
    }

    /// <inheritdoc />
    public override string TableName => "F46011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IQMCU", "IQMCU", JdeDataType.String, 24, true, true),
        new JdeField("IQPRP6", "IQPRP6", JdeDataType.String, 12, true, true),
        new JdeField("IQITM", "IQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IQUOM", "IQUOM", JdeDataType.String, 4, true, true),
        new JdeField("IQGWID", "IQGWID", JdeDataType.Numeric),
        new JdeField("IQGDEP", "IQGDEP", JdeDataType.Numeric),
        new JdeField("IQGHET", "IQGHET", JdeDataType.Numeric),
        new JdeField("IQWIUM", "IQWIUM", JdeDataType.String, 4),
        new JdeField("IQGCUB", "IQGCUB", JdeDataType.Numeric),
        new JdeField("IQVUMD", "IQVUMD", JdeDataType.String, 4),
        new JdeField("IQGWEI", "IQGWEI", JdeDataType.Numeric),
        new JdeField("IQUWUM", "IQUWUM", JdeDataType.String, 4),
        new JdeField("IQDMTH", "IQDMTH", JdeDataType.String, 2),
        new JdeField("IQCRMT", "IQCRMT", JdeDataType.String, 2),
        new JdeField("IQEQUS", "IQEQUS", JdeDataType.String, 2),
        new JdeField("IQAROT", "IQAROT", JdeDataType.String, 2),
        new JdeField("IQABKD", "IQABKD", JdeDataType.String, 2),
        new JdeField("IQAROL", "IQAROL", JdeDataType.String, 2),
        new JdeField("IQSLIM", "IQSLIM", JdeDataType.Numeric),
        new JdeField("IQEQTY", "IQEQTY", JdeDataType.String, 10),
        new JdeField("IQRPCK", "IQRPCK", JdeDataType.String, 2),
        new JdeField("IQPACK", "IQPACK", JdeDataType.String, 8),
        new JdeField("IQLIPL", "IQLIPL", JdeDataType.String, 2),
        new JdeField("IQPPTG", "IQPPTG", JdeDataType.String, 2),
        new JdeField("IQPKTG", "IQPKTG", JdeDataType.String, 2),
        new JdeField("IQPRTG", "IQPRTG", JdeDataType.String, 2),
        new JdeField("IQPTRA", "IQPTRA", JdeDataType.String, 6),
        new JdeField("IQKTRA", "IQKTRA", JdeDataType.String, 6),
        new JdeField("IQRTRA", "IQRTRA", JdeDataType.String, 6),
        new JdeField("IQUSER", "IQUSER", JdeDataType.String, 20),
        new JdeField("IQPID", "IQPID", JdeDataType.String, 20),
        new JdeField("IQJOBN", "IQJOBN", JdeDataType.String, 20),
        new JdeField("IQUPMJ", "IQUPMJ", JdeDataType.Numeric),
        new JdeField("IQTDAY", "IQTDAY", JdeDataType.Numeric),
        new JdeField("IQUCCU", "IQUCCU", JdeDataType.String, 2),
        new JdeField("IQPKBKD", "IQPKBKD", JdeDataType.String, 2),
        new JdeField("IQIUOMFUC1", "IQIUOMFUC1", JdeDataType.String, 2),
        new JdeField("IQIUOMFUC2", "IQIUOMFUC2", JdeDataType.String, 2),
        new JdeField("IQIUOMFUS1", "IQIUOMFUS1", JdeDataType.String, 6),
        new JdeField("IQIUOMFUS2", "IQIUOMFUS2", JdeDataType.String, 80),
        new JdeField("IQIUOMFUN1", "IQIUOMFUN1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46011_0", "Primary Key on IQMCU, IQPRP6, IQITM, IQUOM", new[] { "IQMCU", "IQPRP6", "IQITM", "IQUOM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46011_2", "Index on IQMCU, IQITM, IQUOM", new[] { "IQMCU", "IQITM", "IQUOM" }),
        new JdeIndex("F46011_3", "Index on IQMCU, IQPRP6, IQUOM", new[] { "IQMCU", "IQPRP6", "IQUOM" })
    };
}
