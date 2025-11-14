using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5280W - .
/// </summary>
public class F5280W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GYDOCO.
        /// </summary>
        public const string GYDOCO = "GYDOCO";

        /// <summary>
        /// GYDCTO.
        /// </summary>
        public const string GYDCTO = "GYDCTO";

        /// <summary>
        /// GYKCOO.
        /// </summary>
        public const string GYKCOO = "GYKCOO";

        /// <summary>
        /// GYCOCH.
        /// </summary>
        public const string GYCOCH = "GYCOCH";

        /// <summary>
        /// GYLNID.
        /// </summary>
        public const string GYLNID = "GYLNID";

        /// <summary>
        /// GYOPIM.
        /// </summary>
        public const string GYOPIM = "GYOPIM";

        /// <summary>
        /// GYDGL.
        /// </summary>
        public const string GYDGL = "GYDGL";

        /// <summary>
        /// GYPN.
        /// </summary>
        public const string GYPN = "GYPN";

        /// <summary>
        /// GYFY.
        /// </summary>
        public const string GYFY = "GYFY";

        /// <summary>
        /// GYCTRY.
        /// </summary>
        public const string GYCTRY = "GYCTRY";

        /// <summary>
        /// GYCRAM.
        /// </summary>
        public const string GYCRAM = "GYCRAM";

        /// <summary>
        /// GYCRFA.
        /// </summary>
        public const string GYCRFA = "GYCRFA";

        /// <summary>
        /// GYCRUN.
        /// </summary>
        public const string GYCRUN = "GYCRUN";

        /// <summary>
        /// GYCRCD.
        /// </summary>
        public const string GYCRCD = "GYCRCD";

        /// <summary>
        /// GYCRCF.
        /// </summary>
        public const string GYCRCF = "GYCRCF";

        /// <summary>
        /// GYAA.
        /// </summary>
        public const string GYAA = "GYAA";

        /// <summary>
        /// GYAA2.
        /// </summary>
        public const string GYAA2 = "GYAA2";

        /// <summary>
        /// GYBCI.
        /// </summary>
        public const string GYBCI = "GYBCI";

        /// <summary>
        /// GYDTEJ.
        /// </summary>
        public const string GYDTEJ = "GYDTEJ";

        /// <summary>
        /// GYSBL.
        /// </summary>
        public const string GYSBL = "GYSBL";

        /// <summary>
        /// GYSBLT.
        /// </summary>
        public const string GYSBLT = "GYSBLT";

        /// <summary>
        /// GYWR07.
        /// </summary>
        public const string GYWR07 = "GYWR07";

        /// <summary>
        /// GYMCU.
        /// </summary>
        public const string GYMCU = "GYMCU";

        /// <summary>
        /// GYRP11.
        /// </summary>
        public const string GYRP11 = "GYRP11";

        /// <summary>
        /// GYAN8.
        /// </summary>
        public const string GYAN8 = "GYAN8";

        /// <summary>
        /// GYHMCU.
        /// </summary>
        public const string GYHMCU = "GYHMCU";

        /// <summary>
        /// GYCO.
        /// </summary>
        public const string GYCO = "GYCO";

        /// <summary>
        /// GYEQCG.
        /// </summary>
        public const string GYEQCG = "GYEQCG";

        /// <summary>
        /// GYCCOD.
        /// </summary>
        public const string GYCCOD = "GYCCOD";

        /// <summary>
        /// GYTLNK.
        /// </summary>
        public const string GYTLNK = "GYTLNK";

        /// <summary>
        /// GYELGC.
        /// </summary>
        public const string GYELGC = "GYELGC";

        /// <summary>
        /// GYICU.
        /// </summary>
        public const string GYICU = "GYICU";

        /// <summary>
        /// GYPRSQ.
        /// </summary>
        public const string GYPRSQ = "GYPRSQ";

        /// <summary>
        /// GYSBSQ.
        /// </summary>
        public const string GYSBSQ = "GYSBSQ";

        /// <summary>
        /// GYSCSQ.
        /// </summary>
        public const string GYSCSQ = "GYSCSQ";

        /// <summary>
        /// GYSLNK.
        /// </summary>
        public const string GYSLNK = "GYSLNK";

        /// <summary>
        /// GYCLNK.
        /// </summary>
        public const string GYCLNK = "GYCLNK";

        /// <summary>
        /// GYCRRM.
        /// </summary>
        public const string GYCRRM = "GYCRRM";

        /// <summary>
        /// GYPRTP.
        /// </summary>
        public const string GYPRTP = "GYPRTP";

        /// <summary>
        /// GYOORA.
        /// </summary>
        public const string GYOORA = "GYOORA";

        /// <summary>
        /// GYHLD.
        /// </summary>
        public const string GYHLD = "GYHLD";

        /// <summary>
        /// GYUKID.
        /// </summary>
        public const string GYUKID = "GYUKID";

        /// <summary>
        /// GYJOBN.
        /// </summary>
        public const string GYJOBN = "GYJOBN";

        /// <summary>
        /// GYPID.
        /// </summary>
        public const string GYPID = "GYPID";

        /// <summary>
        /// GYUPMT.
        /// </summary>
        public const string GYUPMT = "GYUPMT";

        /// <summary>
        /// GYUSER.
        /// </summary>
        public const string GYUSER = "GYUSER";

        /// <summary>
        /// GYUPMJ.
        /// </summary>
        public const string GYUPMJ = "GYUPMJ";

        /// <summary>
        /// GYPRTPG.
        /// </summary>
        public const string GYPRTPG = "GYPRTPG";
    }

    /// <inheritdoc />
    public override string TableName => "F5280W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GYDOCO", "GYDOCO", JdeDataType.Numeric),
        new JdeField("GYDCTO", "GYDCTO", JdeDataType.String, 4),
        new JdeField("GYKCOO", "GYKCOO", JdeDataType.String, 10),
        new JdeField("GYCOCH", "GYCOCH", JdeDataType.String, 6),
        new JdeField("GYLNID", "GYLNID", JdeDataType.Numeric),
        new JdeField("GYOPIM", "GYOPIM", JdeDataType.String, 30),
        new JdeField("GYDGL", "GYDGL", JdeDataType.Numeric),
        new JdeField("GYPN", "GYPN", JdeDataType.Numeric),
        new JdeField("GYFY", "GYFY", JdeDataType.Numeric),
        new JdeField("GYCTRY", "GYCTRY", JdeDataType.Numeric),
        new JdeField("GYCRAM", "GYCRAM", JdeDataType.Numeric),
        new JdeField("GYCRFA", "GYCRFA", JdeDataType.Numeric),
        new JdeField("GYCRUN", "GYCRUN", JdeDataType.Numeric),
        new JdeField("GYCRCD", "GYCRCD", JdeDataType.String, 6),
        new JdeField("GYCRCF", "GYCRCF", JdeDataType.String, 6),
        new JdeField("GYAA", "GYAA", JdeDataType.Numeric),
        new JdeField("GYAA2", "GYAA2", JdeDataType.Numeric),
        new JdeField("GYBCI", "GYBCI", JdeDataType.Numeric),
        new JdeField("GYDTEJ", "GYDTEJ", JdeDataType.Numeric),
        new JdeField("GYSBL", "GYSBL", JdeDataType.String, 16),
        new JdeField("GYSBLT", "GYSBLT", JdeDataType.String, 2),
        new JdeField("GYWR07", "GYWR07", JdeDataType.String, 6),
        new JdeField("GYMCU", "GYMCU", JdeDataType.String, 24),
        new JdeField("GYRP11", "GYRP11", JdeDataType.String, 6),
        new JdeField("GYAN8", "GYAN8", JdeDataType.Numeric),
        new JdeField("GYHMCU", "GYHMCU", JdeDataType.String, 24),
        new JdeField("GYCO", "GYCO", JdeDataType.String, 10),
        new JdeField("GYEQCG", "GYEQCG", JdeDataType.String, 18),
        new JdeField("GYCCOD", "GYCCOD", JdeDataType.String, 10),
        new JdeField("GYTLNK", "GYTLNK", JdeDataType.Numeric),
        new JdeField("GYELGC", "GYELGC", JdeDataType.String, 2),
        new JdeField("GYICU", "GYICU", JdeDataType.Numeric),
        new JdeField("GYPRSQ", "GYPRSQ", JdeDataType.Numeric),
        new JdeField("GYSBSQ", "GYSBSQ", JdeDataType.Numeric),
        new JdeField("GYSCSQ", "GYSCSQ", JdeDataType.Numeric),
        new JdeField("GYSLNK", "GYSLNK", JdeDataType.Numeric),
        new JdeField("GYCLNK", "GYCLNK", JdeDataType.Numeric),
        new JdeField("GYCRRM", "GYCRRM", JdeDataType.String, 2),
        new JdeField("GYPRTP", "GYPRTP", JdeDataType.String, 2),
        new JdeField("GYOORA", "GYOORA", JdeDataType.String, 2),
        new JdeField("GYHLD", "GYHLD", JdeDataType.String, 2),
        new JdeField("GYUKID", "GYUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GYJOBN", "GYJOBN", JdeDataType.String, 20),
        new JdeField("GYPID", "GYPID", JdeDataType.String, 20),
        new JdeField("GYUPMT", "GYUPMT", JdeDataType.Numeric),
        new JdeField("GYUSER", "GYUSER", JdeDataType.String, 20),
        new JdeField("GYUPMJ", "GYUPMJ", JdeDataType.Numeric),
        new JdeField("GYPRTPG", "GYPRTPG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5280W_0", "Primary Key on GYUKID", new[] { "GYUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5280W_2", "Index on GYICU, GYDOCO, GYDCTO, GYKCOO, GYCOCH, GYLNID, GYBCI", new[] { "GYICU", "GYDOCO", "GYDCTO", "GYKCOO", "GYCOCH", "GYLNID", "GYBCI" }),
        new JdeIndex("F5280W_3", "Index on GYICU, GYCCOD", new[] { "GYICU", "GYCCOD" }),
        new JdeIndex("F5280W_4", "Index on GYICU, GYDOCO, GYPRTPG", new[] { "GYICU", "GYDOCO", "GYPRTPG" })
    };
}
