using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49621 - .
/// </summary>
public class F49621 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDVMCU.
        /// </summary>
        public const string TDVMCU = "TDVMCU";

        /// <summary>
        /// TDLDNM.
        /// </summary>
        public const string TDLDNM = "TDLDNM";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDLCMP.
        /// </summary>
        public const string TDLCMP = "TDLCMP";

        /// <summary>
        /// TDSRCO.
        /// </summary>
        public const string TDSRCO = "TDSRCO";

        /// <summary>
        /// TDTRPL.
        /// </summary>
        public const string TDTRPL = "TDTRPL";

        /// <summary>
        /// TDSTSQ.
        /// </summary>
        public const string TDSTSQ = "TDSTSQ";

        /// <summary>
        /// TDSHPN.
        /// </summary>
        public const string TDSHPN = "TDSHPN";

        /// <summary>
        /// TDRSSN.
        /// </summary>
        public const string TDRSSN = "TDRSSN";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDACMP.
        /// </summary>
        public const string TDACMP = "TDACMP";

        /// <summary>
        /// TDSO02.
        /// </summary>
        public const string TDSO02 = "TDSO02";

        /// <summary>
        /// TDSCWT.
        /// </summary>
        public const string TDSCWT = "TDSCWT";

        /// <summary>
        /// TDWTUM.
        /// </summary>
        public const string TDWTUM = "TDWTUM";

        /// <summary>
        /// TDAWGT.
        /// </summary>
        public const string TDAWGT = "TDAWGT";

        /// <summary>
        /// TDBUM5.
        /// </summary>
        public const string TDBUM5 = "TDBUM5";

        /// <summary>
        /// TDSCVL.
        /// </summary>
        public const string TDSCVL = "TDSCVL";

        /// <summary>
        /// TDVLUM.
        /// </summary>
        public const string TDVLUM = "TDVLUM";

        /// <summary>
        /// TDAABR.
        /// </summary>
        public const string TDAABR = "TDAABR";

        /// <summary>
        /// TDSTOK.
        /// </summary>
        public const string TDSTOK = "TDSTOK";

        /// <summary>
        /// TDBUM3.
        /// </summary>
        public const string TDBUM3 = "TDBUM3";

        /// <summary>
        /// TDSCLQ.
        /// </summary>
        public const string TDSCLQ = "TDSCLQ";

        /// <summary>
        /// TDUOM.
        /// </summary>
        public const string TDUOM = "TDUOM";

        /// <summary>
        /// TDSCLP.
        /// </summary>
        public const string TDSCLP = "TDSCLP";

        /// <summary>
        /// TDSOQS.
        /// </summary>
        public const string TDSOQS = "TDSOQS";

        /// <summary>
        /// TDTRUM.
        /// </summary>
        public const string TDTRUM = "TDTRUM";

        /// <summary>
        /// TDDSCD.
        /// </summary>
        public const string TDDSCD = "TDDSCD";

        /// <summary>
        /// TDOLLR.
        /// </summary>
        public const string TDOLLR = "TDOLLR";

        /// <summary>
        /// TDDLVF.
        /// </summary>
        public const string TDDLVF = "TDDLVF";

        /// <summary>
        /// TDDATY.
        /// </summary>
        public const string TDDATY = "TDDATY";

        /// <summary>
        /// TDADST.
        /// </summary>
        public const string TDADST = "TDADST";

        /// <summary>
        /// TDQLTR.
        /// </summary>
        public const string TDQLTR = "TDQLTR";

        /// <summary>
        /// TDQLTS.
        /// </summary>
        public const string TDQLTS = "TDQLTS";

        /// <summary>
        /// TDURCD.
        /// </summary>
        public const string TDURCD = "TDURCD";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDTDAY.
        /// </summary>
        public const string TDTDAY = "TDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49621";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDVMCU", "TDVMCU", JdeDataType.String, 24, true, true),
        new JdeField("TDLDNM", "TDLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDLCMP", "TDLCMP", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSRCO", "TDSRCO", JdeDataType.String, 2),
        new JdeField("TDTRPL", "TDTRPL", JdeDataType.Numeric),
        new JdeField("TDSTSQ", "TDSTSQ", JdeDataType.Numeric),
        new JdeField("TDSHPN", "TDSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("TDRSSN", "TDRSSN", JdeDataType.Numeric),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDACMP", "TDACMP", JdeDataType.Numeric),
        new JdeField("TDSO02", "TDSO02", JdeDataType.String, 2),
        new JdeField("TDSCWT", "TDSCWT", JdeDataType.Numeric),
        new JdeField("TDWTUM", "TDWTUM", JdeDataType.String, 4),
        new JdeField("TDAWGT", "TDAWGT", JdeDataType.Numeric),
        new JdeField("TDBUM5", "TDBUM5", JdeDataType.String, 4),
        new JdeField("TDSCVL", "TDSCVL", JdeDataType.Numeric),
        new JdeField("TDVLUM", "TDVLUM", JdeDataType.String, 4),
        new JdeField("TDAABR", "TDAABR", JdeDataType.Numeric),
        new JdeField("TDSTOK", "TDSTOK", JdeDataType.Numeric),
        new JdeField("TDBUM3", "TDBUM3", JdeDataType.String, 4),
        new JdeField("TDSCLQ", "TDSCLQ", JdeDataType.Numeric),
        new JdeField("TDUOM", "TDUOM", JdeDataType.String, 4),
        new JdeField("TDSCLP", "TDSCLP", JdeDataType.Numeric),
        new JdeField("TDSOQS", "TDSOQS", JdeDataType.Numeric),
        new JdeField("TDTRUM", "TDTRUM", JdeDataType.String, 4),
        new JdeField("TDDSCD", "TDDSCD", JdeDataType.String, 2),
        new JdeField("TDOLLR", "TDOLLR", JdeDataType.Numeric),
        new JdeField("TDDLVF", "TDDLVF", JdeDataType.String, 2),
        new JdeField("TDDATY", "TDDATY", JdeDataType.String, 2),
        new JdeField("TDADST", "TDADST", JdeDataType.String, 2),
        new JdeField("TDQLTR", "TDQLTR", JdeDataType.String, 2),
        new JdeField("TDQLTS", "TDQLTS", JdeDataType.String, 2),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDTDAY", "TDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49621_0", "Primary Key on TDVMCU, TDLDNM, TDDOCO, TDDCTO, TDKCOO, TDLNID, TDSHPN, TDLCMP", new[] { "TDVMCU", "TDLDNM", "TDDOCO", "TDDCTO", "TDKCOO", "TDLNID", "TDSHPN", "TDLCMP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49621_2", "Index on TDVMCU, TDLDNM, TDTRPL, TDLCMP, TDITM, TDSTSQ", new[] { "TDVMCU", "TDLDNM", "TDTRPL", "TDLCMP", "TDITM", "TDSTSQ" })
    };
}
