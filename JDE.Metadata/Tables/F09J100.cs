using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J100 - .
/// </summary>
public class F09J100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCJVNAME.
        /// </summary>
        public const string OCJVNAME = "OCJVNAME";

        /// <summary>
        /// OCMCU.
        /// </summary>
        public const string OCMCU = "OCMCU";

        /// <summary>
        /// OCJVOVN.
        /// </summary>
        public const string OCJVOVN = "OCJVOVN";

        /// <summary>
        /// OCJVOM.
        /// </summary>
        public const string OCJVOM = "OCJVOM";

        /// <summary>
        /// OCJVLNID.
        /// </summary>
        public const string OCJVLNID = "OCJVLNID";

        /// <summary>
        /// OCCTRY.
        /// </summary>
        public const string OCCTRY = "OCCTRY";

        /// <summary>
        /// OCYR.
        /// </summary>
        public const string OCYR = "OCYR";

        /// <summary>
        /// OCMT.
        /// </summary>
        public const string OCMT = "OCMT";

        /// <summary>
        /// OCEFTM.
        /// </summary>
        public const string OCEFTM = "OCEFTM";

        /// <summary>
        /// OCCO.
        /// </summary>
        public const string OCCO = "OCCO";

        /// <summary>
        /// OCMCUS.
        /// </summary>
        public const string OCMCUS = "OCMCUS";

        /// <summary>
        /// OCJVRMCU.
        /// </summary>
        public const string OCJVRMCU = "OCJVRMCU";

        /// <summary>
        /// OCJVANOV.
        /// </summary>
        public const string OCJVANOV = "OCJVANOV";

        /// <summary>
        /// OCJVINDATE.
        /// </summary>
        public const string OCJVINDATE = "OCJVINDATE";

        /// <summary>
        /// OCOHCA.
        /// </summary>
        public const string OCOHCA = "OCOHCA";

        /// <summary>
        /// OCOHCH.
        /// </summary>
        public const string OCOHCH = "OCOHCH";

        /// <summary>
        /// OCCRCD.
        /// </summary>
        public const string OCCRCD = "OCCRCD";

        /// <summary>
        /// OCJVSTFRM.
        /// </summary>
        public const string OCJVSTFRM = "OCJVSTFRM";

        /// <summary>
        /// OCJVEIX.
        /// </summary>
        public const string OCJVEIX = "OCJVEIX";

        /// <summary>
        /// OCJVAGN.
        /// </summary>
        public const string OCJVAGN = "OCJVAGN";

        /// <summary>
        /// OCJVOB.
        /// </summary>
        public const string OCJVOB = "OCJVOB";

        /// <summary>
        /// OCOHMCU.
        /// </summary>
        public const string OCOHMCU = "OCOHMCU";

        /// <summary>
        /// OCOHOBJ.
        /// </summary>
        public const string OCOHOBJ = "OCOHOBJ";

        /// <summary>
        /// OCOHSUB.
        /// </summary>
        public const string OCOHSUB = "OCOHSUB";

        /// <summary>
        /// OCDOC.
        /// </summary>
        public const string OCDOC = "OCDOC";

        /// <summary>
        /// OCDCT.
        /// </summary>
        public const string OCDCT = "OCDCT";

        /// <summary>
        /// OCJELN.
        /// </summary>
        public const string OCJELN = "OCJELN";

        /// <summary>
        /// OCDGJ.
        /// </summary>
        public const string OCDGJ = "OCDGJ";

        /// <summary>
        /// OCKCO.
        /// </summary>
        public const string OCKCO = "OCKCO";

        /// <summary>
        /// OCLT.
        /// </summary>
        public const string OCLT = "OCLT";

        /// <summary>
        /// OCEXTL.
        /// </summary>
        public const string OCEXTL = "OCEXTL";

        /// <summary>
        /// OCJVOVID.
        /// </summary>
        public const string OCJVOVID = "OCJVOVID";

        /// <summary>
        /// OCJETS.
        /// </summary>
        public const string OCJETS = "OCJETS";

        /// <summary>
        /// OCUKID.
        /// </summary>
        public const string OCUKID = "OCUKID";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCTORG.
        /// </summary>
        public const string OCTORG = "OCTORG";

        /// <summary>
        /// OCUPMT.
        /// </summary>
        public const string OCUPMT = "OCUPMT";

        /// <summary>
        /// OCMKEY.
        /// </summary>
        public const string OCMKEY = "OCMKEY";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCENTJ.
        /// </summary>
        public const string OCENTJ = "OCENTJ";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCJVOHDT1.
        /// </summary>
        public const string OCJVOHDT1 = "OCJVOHDT1";

        /// <summary>
        /// OCJVOHDT2.
        /// </summary>
        public const string OCJVOHDT2 = "OCJVOHDT2";

        /// <summary>
        /// OCJVOHDT3.
        /// </summary>
        public const string OCJVOHDT3 = "OCJVOHDT3";

        /// <summary>
        /// OCJVOHDT4.
        /// </summary>
        public const string OCJVOHDT4 = "OCJVOHDT4";

        /// <summary>
        /// OCJVOHFC1.
        /// </summary>
        public const string OCJVOHFC1 = "OCJVOHFC1";

        /// <summary>
        /// OCJVOHFC2.
        /// </summary>
        public const string OCJVOHFC2 = "OCJVOHFC2";

        /// <summary>
        /// OCJVOHFC3.
        /// </summary>
        public const string OCJVOHFC3 = "OCJVOHFC3";

        /// <summary>
        /// OCJVOHFC4.
        /// </summary>
        public const string OCJVOHFC4 = "OCJVOHFC4";

        /// <summary>
        /// OCJVOHMN1.
        /// </summary>
        public const string OCJVOHMN1 = "OCJVOHMN1";

        /// <summary>
        /// OCJVOHFN2.
        /// </summary>
        public const string OCJVOHFN2 = "OCJVOHFN2";

        /// <summary>
        /// OCJVOHFN3.
        /// </summary>
        public const string OCJVOHFN3 = "OCJVOHFN3";

        /// <summary>
        /// OCJVOHFN4.
        /// </summary>
        public const string OCJVOHFN4 = "OCJVOHFN4";

        /// <summary>
        /// OCJVOHST1.
        /// </summary>
        public const string OCJVOHST1 = "OCJVOHST1";

        /// <summary>
        /// OCJVOHST2.
        /// </summary>
        public const string OCJVOHST2 = "OCJVOHST2";

        /// <summary>
        /// OCJVOHST3.
        /// </summary>
        public const string OCJVOHST3 = "OCJVOHST3";

        /// <summary>
        /// OCJVOHST4.
        /// </summary>
        public const string OCJVOHST4 = "OCJVOHST4";

        /// <summary>
        /// OCJVOHUC1.
        /// </summary>
        public const string OCJVOHUC1 = "OCJVOHUC1";

        /// <summary>
        /// OCJVOHUC2.
        /// </summary>
        public const string OCJVOHUC2 = "OCJVOHUC2";

        /// <summary>
        /// OCJVOHUC3.
        /// </summary>
        public const string OCJVOHUC3 = "OCJVOHUC3";

        /// <summary>
        /// OCJVOHUC4.
        /// </summary>
        public const string OCJVOHUC4 = "OCJVOHUC4";

        /// <summary>
        /// OCJVOHUC5.
        /// </summary>
        public const string OCJVOHUC5 = "OCJVOHUC5";

        /// <summary>
        /// OCJVOHUDT1.
        /// </summary>
        public const string OCJVOHUDT1 = "OCJVOHUDT1";

        /// <summary>
        /// OCJVOHUDT2.
        /// </summary>
        public const string OCJVOHUDT2 = "OCJVOHUDT2";

        /// <summary>
        /// OCJVOHUDT3.
        /// </summary>
        public const string OCJVOHUDT3 = "OCJVOHUDT3";

        /// <summary>
        /// OCJVOHUDT4.
        /// </summary>
        public const string OCJVOHUDT4 = "OCJVOHUDT4";

        /// <summary>
        /// OCJVOHUDT5.
        /// </summary>
        public const string OCJVOHUDT5 = "OCJVOHUDT5";

        /// <summary>
        /// OCJVOHUM1.
        /// </summary>
        public const string OCJVOHUM1 = "OCJVOHUM1";

        /// <summary>
        /// OCJVOHUM2.
        /// </summary>
        public const string OCJVOHUM2 = "OCJVOHUM2";

        /// <summary>
        /// OCJVOHUM3.
        /// </summary>
        public const string OCJVOHUM3 = "OCJVOHUM3";

        /// <summary>
        /// OCJVOHUM4.
        /// </summary>
        public const string OCJVOHUM4 = "OCJVOHUM4";

        /// <summary>
        /// OCJVOHUM5.
        /// </summary>
        public const string OCJVOHUM5 = "OCJVOHUM5";

        /// <summary>
        /// OCJVOHURF1.
        /// </summary>
        public const string OCJVOHURF1 = "OCJVOHURF1";

        /// <summary>
        /// OCJVOHURF2.
        /// </summary>
        public const string OCJVOHURF2 = "OCJVOHURF2";

        /// <summary>
        /// OCJVOHURF3.
        /// </summary>
        public const string OCJVOHURF3 = "OCJVOHURF3";

        /// <summary>
        /// OCJVOHURF4.
        /// </summary>
        public const string OCJVOHURF4 = "OCJVOHURF4";

        /// <summary>
        /// OCJVOHURF5.
        /// </summary>
        public const string OCJVOHURF5 = "OCJVOHURF5";

        /// <summary>
        /// OCJVOHURN1.
        /// </summary>
        public const string OCJVOHURN1 = "OCJVOHURN1";

        /// <summary>
        /// OCJVOHURN2.
        /// </summary>
        public const string OCJVOHURN2 = "OCJVOHURN2";

        /// <summary>
        /// OCJVOHURN3.
        /// </summary>
        public const string OCJVOHURN3 = "OCJVOHURN3";

        /// <summary>
        /// OCJVOHURN4.
        /// </summary>
        public const string OCJVOHURN4 = "OCJVOHURN4";

        /// <summary>
        /// OCJVOHURN5.
        /// </summary>
        public const string OCJVOHURN5 = "OCJVOHURN5";

        /// <summary>
        /// OCJVOHUST1.
        /// </summary>
        public const string OCJVOHUST1 = "OCJVOHUST1";

        /// <summary>
        /// OCJVOHUST2.
        /// </summary>
        public const string OCJVOHUST2 = "OCJVOHUST2";

        /// <summary>
        /// OCJVOHUST3.
        /// </summary>
        public const string OCJVOHUST3 = "OCJVOHUST3";

        /// <summary>
        /// OCJVOHUST4.
        /// </summary>
        public const string OCJVOHUST4 = "OCJVOHUST4";

        /// <summary>
        /// OCJVOHUST5.
        /// </summary>
        public const string OCJVOHUST5 = "OCJVOHUST5";
    }

    /// <inheritdoc />
    public override string TableName => "F09J100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCJVNAME", "OCJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("OCMCU", "OCMCU", JdeDataType.String, 24, true, true),
        new JdeField("OCJVOVN", "OCJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("OCJVOM", "OCJVOM", JdeDataType.String, 4, true, true),
        new JdeField("OCJVLNID", "OCJVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OCCTRY", "OCCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("OCYR", "OCYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OCMT", "OCMT", JdeDataType.Numeric, null, true, true),
        new JdeField("OCEFTM", "OCEFTM", JdeDataType.Numeric),
        new JdeField("OCCO", "OCCO", JdeDataType.String, 10),
        new JdeField("OCMCUS", "OCMCUS", JdeDataType.String, 24),
        new JdeField("OCJVRMCU", "OCJVRMCU", JdeDataType.String, 24),
        new JdeField("OCJVANOV", "OCJVANOV", JdeDataType.String, 2),
        new JdeField("OCJVINDATE", "OCJVINDATE", JdeDataType.Numeric),
        new JdeField("OCOHCA", "OCOHCA", JdeDataType.Numeric),
        new JdeField("OCOHCH", "OCOHCH", JdeDataType.Numeric),
        new JdeField("OCCRCD", "OCCRCD", JdeDataType.String, 6),
        new JdeField("OCJVSTFRM", "OCJVSTFRM", JdeDataType.String, 2),
        new JdeField("OCJVEIX", "OCJVEIX", JdeDataType.String, 10),
        new JdeField("OCJVAGN", "OCJVAGN", JdeDataType.String, 40),
        new JdeField("OCJVOB", "OCJVOB", JdeDataType.String, 4),
        new JdeField("OCOHMCU", "OCOHMCU", JdeDataType.String, 24),
        new JdeField("OCOHOBJ", "OCOHOBJ", JdeDataType.String, 12),
        new JdeField("OCOHSUB", "OCOHSUB", JdeDataType.String, 16),
        new JdeField("OCDOC", "OCDOC", JdeDataType.Numeric),
        new JdeField("OCDCT", "OCDCT", JdeDataType.String, 4),
        new JdeField("OCJELN", "OCJELN", JdeDataType.Numeric),
        new JdeField("OCDGJ", "OCDGJ", JdeDataType.Numeric),
        new JdeField("OCKCO", "OCKCO", JdeDataType.String, 10),
        new JdeField("OCLT", "OCLT", JdeDataType.String, 4),
        new JdeField("OCEXTL", "OCEXTL", JdeDataType.String, 4),
        new JdeField("OCJVOVID", "OCJVOVID", JdeDataType.Numeric),
        new JdeField("OCJETS", "OCJETS", JdeDataType.String, 6),
        new JdeField("OCUKID", "OCUKID", JdeDataType.Numeric),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCTORG", "OCTORG", JdeDataType.String, 20),
        new JdeField("OCUPMT", "OCUPMT", JdeDataType.Numeric),
        new JdeField("OCMKEY", "OCMKEY", JdeDataType.String, 30),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCENTJ", "OCENTJ", JdeDataType.Numeric),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCJVOHDT1", "OCJVOHDT1", JdeDataType.Numeric),
        new JdeField("OCJVOHDT2", "OCJVOHDT2", JdeDataType.Numeric),
        new JdeField("OCJVOHDT3", "OCJVOHDT3", JdeDataType.Numeric),
        new JdeField("OCJVOHDT4", "OCJVOHDT4", JdeDataType.Numeric),
        new JdeField("OCJVOHFC1", "OCJVOHFC1", JdeDataType.String, 2),
        new JdeField("OCJVOHFC2", "OCJVOHFC2", JdeDataType.String, 2),
        new JdeField("OCJVOHFC3", "OCJVOHFC3", JdeDataType.String, 2),
        new JdeField("OCJVOHFC4", "OCJVOHFC4", JdeDataType.String, 2),
        new JdeField("OCJVOHMN1", "OCJVOHMN1", JdeDataType.Numeric),
        new JdeField("OCJVOHFN2", "OCJVOHFN2", JdeDataType.Numeric),
        new JdeField("OCJVOHFN3", "OCJVOHFN3", JdeDataType.Numeric),
        new JdeField("OCJVOHFN4", "OCJVOHFN4", JdeDataType.Numeric),
        new JdeField("OCJVOHST1", "OCJVOHST1", JdeDataType.String, 160),
        new JdeField("OCJVOHST2", "OCJVOHST2", JdeDataType.String, 160),
        new JdeField("OCJVOHST3", "OCJVOHST3", JdeDataType.String, 160),
        new JdeField("OCJVOHST4", "OCJVOHST4", JdeDataType.String, 160),
        new JdeField("OCJVOHUC1", "OCJVOHUC1", JdeDataType.String, 4),
        new JdeField("OCJVOHUC2", "OCJVOHUC2", JdeDataType.String, 4),
        new JdeField("OCJVOHUC3", "OCJVOHUC3", JdeDataType.String, 4),
        new JdeField("OCJVOHUC4", "OCJVOHUC4", JdeDataType.String, 4),
        new JdeField("OCJVOHUC5", "OCJVOHUC5", JdeDataType.String, 4),
        new JdeField("OCJVOHUDT1", "OCJVOHUDT1", JdeDataType.Numeric),
        new JdeField("OCJVOHUDT2", "OCJVOHUDT2", JdeDataType.Numeric),
        new JdeField("OCJVOHUDT3", "OCJVOHUDT3", JdeDataType.Numeric),
        new JdeField("OCJVOHUDT4", "OCJVOHUDT4", JdeDataType.Numeric),
        new JdeField("OCJVOHUDT5", "OCJVOHUDT5", JdeDataType.Numeric),
        new JdeField("OCJVOHUM1", "OCJVOHUM1", JdeDataType.Numeric),
        new JdeField("OCJVOHUM2", "OCJVOHUM2", JdeDataType.Numeric),
        new JdeField("OCJVOHUM3", "OCJVOHUM3", JdeDataType.Numeric),
        new JdeField("OCJVOHUM4", "OCJVOHUM4", JdeDataType.Numeric),
        new JdeField("OCJVOHUM5", "OCJVOHUM5", JdeDataType.Numeric),
        new JdeField("OCJVOHURF1", "OCJVOHURF1", JdeDataType.String, 30),
        new JdeField("OCJVOHURF2", "OCJVOHURF2", JdeDataType.String, 30),
        new JdeField("OCJVOHURF3", "OCJVOHURF3", JdeDataType.String, 30),
        new JdeField("OCJVOHURF4", "OCJVOHURF4", JdeDataType.String, 30),
        new JdeField("OCJVOHURF5", "OCJVOHURF5", JdeDataType.String, 30),
        new JdeField("OCJVOHURN1", "OCJVOHURN1", JdeDataType.Numeric),
        new JdeField("OCJVOHURN2", "OCJVOHURN2", JdeDataType.Numeric),
        new JdeField("OCJVOHURN3", "OCJVOHURN3", JdeDataType.Numeric),
        new JdeField("OCJVOHURN4", "OCJVOHURN4", JdeDataType.Numeric),
        new JdeField("OCJVOHURN5", "OCJVOHURN5", JdeDataType.Numeric),
        new JdeField("OCJVOHUST1", "OCJVOHUST1", JdeDataType.String, 160),
        new JdeField("OCJVOHUST2", "OCJVOHUST2", JdeDataType.String, 160),
        new JdeField("OCJVOHUST3", "OCJVOHUST3", JdeDataType.String, 160),
        new JdeField("OCJVOHUST4", "OCJVOHUST4", JdeDataType.String, 160),
        new JdeField("OCJVOHUST5", "OCJVOHUST5", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J100_0", "Primary Key on OCJVNAME, OCMCU, OCJVOVN, OCJVOM, OCJVLNID, OCCTRY, OCYR, OCMT", new[] { "OCJVNAME", "OCMCU", "OCJVOVN", "OCJVOM", "OCJVLNID", "OCCTRY", "OCYR", "OCMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J100_2", "Index on OCMCU", new[] { "OCMCU" }),
        new JdeIndex("F09J100_3", "Index on OCJVNAME, OCMT, OCYR, OCCTRY", new[] { "OCJVNAME", "OCMT", "OCYR", "OCCTRY" }),
        new JdeIndex("F09J100_4", "Index on OCMCU, OCMT, OCYR, OCCTRY", new[] { "OCMCU", "OCMT", "OCYR", "OCCTRY" }),
        new JdeIndex("F09J100_5", "Index on OCJVNAME", new[] { "OCJVNAME" })
    };
}
