using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A710 - .
/// </summary>
public class F75A710 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SETAXX.
        /// </summary>
        public const string SETAXX = "SETAXX";

        /// <summary>
        /// SEGRPNO.
        /// </summary>
        public const string SEGRPNO = "SEGRPNO";

        /// <summary>
        /// SEASSPD.
        /// </summary>
        public const string SEASSPD = "SEASSPD";

        /// <summary>
        /// SEASSQ.
        /// </summary>
        public const string SEASSQ = "SEASSQ";

        /// <summary>
        /// SEAN8.
        /// </summary>
        public const string SEAN8 = "SEAN8";

        /// <summary>
        /// SEHMCO.
        /// </summary>
        public const string SEHMCO = "SEHMCO";

        /// <summary>
        /// SEPAYD.
        /// </summary>
        public const string SEPAYD = "SEPAYD";

        /// <summary>
        /// SEASPSS.
        /// </summary>
        public const string SEASPSS = "SEASPSS";

        /// <summary>
        /// SEEFTB.
        /// </summary>
        public const string SEEFTB = "SEEFTB";

        /// <summary>
        /// SEEFTE.
        /// </summary>
        public const string SEEFTE = "SEEFTE";

        /// <summary>
        /// SETAXFNO.
        /// </summary>
        public const string SETAXFNO = "SETAXFNO";

        /// <summary>
        /// SEASLPP.
        /// </summary>
        public const string SEASLPP = "SEASLPP";

        /// <summary>
        /// SEG101.
        /// </summary>
        public const string SEG101 = "SEG101";

        /// <summary>
        /// SEASCDP.
        /// </summary>
        public const string SEASCDP = "SEASCDP";

        /// <summary>
        /// SEASPYG.
        /// </summary>
        public const string SEASPYG = "SEASPYG";

        /// <summary>
        /// SEASFIA.
        /// </summary>
        public const string SEASFIA = "SEASFIA";

        /// <summary>
        /// SEASVGA.
        /// </summary>
        public const string SEASVGA = "SEASVGA";

        /// <summary>
        /// SEASVGP.
        /// </summary>
        public const string SEASVGP = "SEASVGP";

        /// <summary>
        /// SEASLHG.
        /// </summary>
        public const string SEASLHG = "SEASLHG";

        /// <summary>
        /// SEASLHP.
        /// </summary>
        public const string SEASLHP = "SEASLHP";

        /// <summary>
        /// SEASSGP.
        /// </summary>
        public const string SEASSGP = "SEASSGP";

        /// <summary>
        /// SEASTSP.
        /// </summary>
        public const string SEASTSP = "SEASTSP";

        /// <summary>
        /// SEASJFG.
        /// </summary>
        public const string SEASJFG = "SEASJFG";

        /// <summary>
        /// SEASJFI.
        /// </summary>
        public const string SEASJFI = "SEASJFI";

        /// <summary>
        /// SEASJFP.
        /// </summary>
        public const string SEASJFP = "SEASJFP";

        /// <summary>
        /// SEASHMG.
        /// </summary>
        public const string SEASHMG = "SEASHMG";

        /// <summary>
        /// SEASHMP.
        /// </summary>
        public const string SEASHMP = "SEASHMP";

        /// <summary>
        /// SEASGPF.
        /// </summary>
        public const string SEASGPF = "SEASGPF";

        /// <summary>
        /// SEASFIT.
        /// </summary>
        public const string SEASFIT = "SEASFIT";

        /// <summary>
        /// SEASFPG.
        /// </summary>
        public const string SEASFPG = "SEASFPG";

        /// <summary>
        /// SESPAFAUT1.
        /// </summary>
        public const string SESPAFAUT1 = "SESPAFAUT1";

        /// <summary>
        /// SECKDT.
        /// </summary>
        public const string SECKDT = "SECKDT";

        /// <summary>
        /// SEASTPN.
        /// </summary>
        public const string SEASTPN = "SEASTPN";

        /// <summary>
        /// SEASSAMT.
        /// </summary>
        public const string SEASSAMT = "SEASSAMT";

        /// <summary>
        /// SEETPTAX.
        /// </summary>
        public const string SEETPTAX = "SEETPTAX";

        /// <summary>
        /// SEASLST.
        /// </summary>
        public const string SEASLST = "SEASLST";

        /// <summary>
        /// SEASLSA.
        /// </summary>
        public const string SEASLSA = "SEASLSA";

        /// <summary>
        /// SEASLSB.
        /// </summary>
        public const string SEASLSB = "SEASLSB";

        /// <summary>
        /// SEASLSD.
        /// </summary>
        public const string SEASLSD = "SEASLSD";

        /// <summary>
        /// SEASLSE.
        /// </summary>
        public const string SEASLSE = "SEASLSE";

        /// <summary>
        /// SEASEAT.
        /// </summary>
        public const string SEASEAT = "SEASEAT";

        /// <summary>
        /// SEASEAO.
        /// </summary>
        public const string SEASEAO = "SEASEAO";

        /// <summary>
        /// SEASEAA.
        /// </summary>
        public const string SEASEAA = "SEASEAA";

        /// <summary>
        /// SEASDDT.
        /// </summary>
        public const string SEASDDT = "SEASDDT";

        /// <summary>
        /// SEASDAT.
        /// </summary>
        public const string SEASDAT = "SEASDAT";

        /// <summary>
        /// SEASSGA.
        /// </summary>
        public const string SEASSGA = "SEASSGA";

        /// <summary>
        /// SEASOTE.
        /// </summary>
        public const string SEASOTE = "SEASOTE";

        /// <summary>
        /// SEASSUP.
        /// </summary>
        public const string SEASSUP = "SEASSUP";

        /// <summary>
        /// SEFBAM.
        /// </summary>
        public const string SEFBAM = "SEFBAM";

        /// <summary>
        /// SEASFBE.
        /// </summary>
        public const string SEASFBE = "SEASFBE";

        /// <summary>
        /// SEASESO.
        /// </summary>
        public const string SEASESO = "SEASESO";

        /// <summary>
        /// SERESIDENT.
        /// </summary>
        public const string SERESIDENT = "SERESIDENT";

        /// <summary>
        /// SEEST.
        /// </summary>
        public const string SEEST = "SEEST";

        /// <summary>
        /// SECTAXFF.
        /// </summary>
        public const string SECTAXFF = "SECTAXFF";

        /// <summary>
        /// SESTDEBT.
        /// </summary>
        public const string SESTDEBT = "SESTDEBT";

        /// <summary>
        /// SEASETS.
        /// </summary>
        public const string SEASETS = "SEASETS";

        /// <summary>
        /// SEASSLI.
        /// </summary>
        public const string SEASSLI = "SEASSLI";

        /// <summary>
        /// SEASPDD.
        /// </summary>
        public const string SEASPDD = "SEASPDD";

        /// <summary>
        /// SEASPDI.
        /// </summary>
        public const string SEASPDI = "SEASPDI";

        /// <summary>
        /// SEASPAI.
        /// </summary>
        public const string SEASPAI = "SEASPAI";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SESPACAUU1.
        /// </summary>
        public const string SESPACAUU1 = "SESPACAUU1";

        /// <summary>
        /// SESPACAUU2.
        /// </summary>
        public const string SESPACAUU2 = "SESPACAUU2";

        /// <summary>
        /// SESPACAUU3.
        /// </summary>
        public const string SESPACAUU3 = "SESPACAUU3";

        /// <summary>
        /// SESPACAUU4.
        /// </summary>
        public const string SESPACAUU4 = "SESPACAUU4";

        /// <summary>
        /// SESPADAUU1.
        /// </summary>
        public const string SESPADAUU1 = "SESPADAUU1";

        /// <summary>
        /// SESPADAUU2.
        /// </summary>
        public const string SESPADAUU2 = "SESPADAUU2";

        /// <summary>
        /// SESPADAUU3.
        /// </summary>
        public const string SESPADAUU3 = "SESPADAUU3";

        /// <summary>
        /// SESPADAUU4.
        /// </summary>
        public const string SESPADAUU4 = "SESPADAUU4";

        /// <summary>
        /// SESPANAUU1.
        /// </summary>
        public const string SESPANAUU1 = "SESPANAUU1";

        /// <summary>
        /// SESPANAUU2.
        /// </summary>
        public const string SESPANAUU2 = "SESPANAUU2";

        /// <summary>
        /// SESPANAUU3.
        /// </summary>
        public const string SESPANAUU3 = "SESPANAUU3";

        /// <summary>
        /// SESPANAUU4.
        /// </summary>
        public const string SESPANAUU4 = "SESPANAUU4";

        /// <summary>
        /// SESPASAUU1.
        /// </summary>
        public const string SESPASAUU1 = "SESPASAUU1";

        /// <summary>
        /// SESPASAUU2.
        /// </summary>
        public const string SESPASAUU2 = "SESPASAUU2";

        /// <summary>
        /// SESPASAUU3.
        /// </summary>
        public const string SESPASAUU3 = "SESPASAUU3";

        /// <summary>
        /// SESPASAUU4.
        /// </summary>
        public const string SESPASAUU4 = "SESPASAUU4";
    }

    /// <inheritdoc />
    public override string TableName => "F75A710";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SETAXX", "SETAXX", JdeDataType.String, 40, true, true),
        new JdeField("SEGRPNO", "SEGRPNO", JdeDataType.String, 22, true, true),
        new JdeField("SEASSPD", "SEASSPD", JdeDataType.Numeric, null, true, true),
        new JdeField("SEASSQ", "SEASSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SEAN8", "SEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SEHMCO", "SEHMCO", JdeDataType.String, 10),
        new JdeField("SEPAYD", "SEPAYD", JdeDataType.String, 20),
        new JdeField("SEASPSS", "SEASPSS", JdeDataType.String, 2),
        new JdeField("SEEFTB", "SEEFTB", JdeDataType.Numeric),
        new JdeField("SEEFTE", "SEEFTE", JdeDataType.Numeric),
        new JdeField("SETAXFNO", "SETAXFNO", JdeDataType.String, 22),
        new JdeField("SEASLPP", "SEASLPP", JdeDataType.String, 2),
        new JdeField("SEG101", "SEG101", JdeDataType.Numeric),
        new JdeField("SEASCDP", "SEASCDP", JdeDataType.Numeric),
        new JdeField("SEASPYG", "SEASPYG", JdeDataType.Numeric),
        new JdeField("SEASFIA", "SEASFIA", JdeDataType.Numeric),
        new JdeField("SEASVGA", "SEASVGA", JdeDataType.Numeric),
        new JdeField("SEASVGP", "SEASVGP", JdeDataType.Numeric),
        new JdeField("SEASLHG", "SEASLHG", JdeDataType.Numeric),
        new JdeField("SEASLHP", "SEASLHP", JdeDataType.Numeric),
        new JdeField("SEASSGP", "SEASSGP", JdeDataType.Numeric),
        new JdeField("SEASTSP", "SEASTSP", JdeDataType.Numeric),
        new JdeField("SEASJFG", "SEASJFG", JdeDataType.Numeric),
        new JdeField("SEASJFI", "SEASJFI", JdeDataType.Numeric),
        new JdeField("SEASJFP", "SEASJFP", JdeDataType.Numeric),
        new JdeField("SEASHMG", "SEASHMG", JdeDataType.Numeric),
        new JdeField("SEASHMP", "SEASHMP", JdeDataType.Numeric),
        new JdeField("SEASGPF", "SEASGPF", JdeDataType.Numeric),
        new JdeField("SEASFIT", "SEASFIT", JdeDataType.Numeric),
        new JdeField("SEASFPG", "SEASFPG", JdeDataType.Numeric),
        new JdeField("SESPAFAUT1", "SESPAFAUT1", JdeDataType.String, 2),
        new JdeField("SECKDT", "SECKDT", JdeDataType.Numeric),
        new JdeField("SEASTPN", "SEASTPN", JdeDataType.Numeric),
        new JdeField("SEASSAMT", "SEASSAMT", JdeDataType.Numeric),
        new JdeField("SEETPTAX", "SEETPTAX", JdeDataType.Numeric),
        new JdeField("SEASLST", "SEASLST", JdeDataType.String, 4),
        new JdeField("SEASLSA", "SEASLSA", JdeDataType.Numeric),
        new JdeField("SEASLSB", "SEASLSB", JdeDataType.Numeric),
        new JdeField("SEASLSD", "SEASLSD", JdeDataType.Numeric),
        new JdeField("SEASLSE", "SEASLSE", JdeDataType.Numeric),
        new JdeField("SEASEAT", "SEASEAT", JdeDataType.String, 4),
        new JdeField("SEASEAO", "SEASEAO", JdeDataType.String, 4),
        new JdeField("SEASEAA", "SEASEAA", JdeDataType.Numeric),
        new JdeField("SEASDDT", "SEASDDT", JdeDataType.String, 4),
        new JdeField("SEASDAT", "SEASDAT", JdeDataType.Numeric),
        new JdeField("SEASSGA", "SEASSGA", JdeDataType.Numeric),
        new JdeField("SEASOTE", "SEASOTE", JdeDataType.Numeric),
        new JdeField("SEASSUP", "SEASSUP", JdeDataType.Numeric),
        new JdeField("SEFBAM", "SEFBAM", JdeDataType.Numeric),
        new JdeField("SEASFBE", "SEASFBE", JdeDataType.Numeric),
        new JdeField("SEASESO", "SEASESO", JdeDataType.String, 2),
        new JdeField("SERESIDENT", "SERESIDENT", JdeDataType.String, 2),
        new JdeField("SEEST", "SEEST", JdeDataType.String, 2),
        new JdeField("SECTAXFF", "SECTAXFF", JdeDataType.String, 2),
        new JdeField("SESTDEBT", "SESTDEBT", JdeDataType.String, 2),
        new JdeField("SEASETS", "SEASETS", JdeDataType.String, 2),
        new JdeField("SEASSLI", "SEASSLI", JdeDataType.String, 2),
        new JdeField("SEASPDD", "SEASPDD", JdeDataType.Numeric),
        new JdeField("SEASPDI", "SEASPDI", JdeDataType.String, 2),
        new JdeField("SEASPAI", "SEASPAI", JdeDataType.String, 2),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SESPACAUU1", "SESPACAUU1", JdeDataType.String, 2),
        new JdeField("SESPACAUU2", "SESPACAUU2", JdeDataType.String, 2),
        new JdeField("SESPACAUU3", "SESPACAUU3", JdeDataType.String, 2),
        new JdeField("SESPACAUU4", "SESPACAUU4", JdeDataType.String, 2),
        new JdeField("SESPADAUU1", "SESPADAUU1", JdeDataType.Numeric),
        new JdeField("SESPADAUU2", "SESPADAUU2", JdeDataType.Numeric),
        new JdeField("SESPADAUU3", "SESPADAUU3", JdeDataType.Numeric),
        new JdeField("SESPADAUU4", "SESPADAUU4", JdeDataType.Numeric),
        new JdeField("SESPANAUU1", "SESPANAUU1", JdeDataType.Numeric),
        new JdeField("SESPANAUU2", "SESPANAUU2", JdeDataType.Numeric),
        new JdeField("SESPANAUU3", "SESPANAUU3", JdeDataType.Numeric),
        new JdeField("SESPANAUU4", "SESPANAUU4", JdeDataType.Numeric),
        new JdeField("SESPASAUU1", "SESPASAUU1", JdeDataType.String, 60),
        new JdeField("SESPASAUU2", "SESPASAUU2", JdeDataType.String, 60),
        new JdeField("SESPASAUU3", "SESPASAUU3", JdeDataType.String, 60),
        new JdeField("SESPASAUU4", "SESPASAUU4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A710_0", "Primary Key on SETAXX, SEGRPNO, SEASSPD, SEASSQ, SEAN8", new[] { "SETAXX", "SEGRPNO", "SEASSPD", "SEASSQ", "SEAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A710_2", "Index on SETAXX, SEGRPNO, SYS_NC00082$, SYS_NC00083$", new[] { "SETAXX", "SEGRPNO", "SYS_NC00082$", "SYS_NC00083$" })
    };
}
