using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740018D - .
/// </summary>
public class F740018D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEDOCO.
        /// </summary>
        public const string DEDOCO = "DEDOCO";

        /// <summary>
        /// DEDCTO.
        /// </summary>
        public const string DEDCTO = "DEDCTO";

        /// <summary>
        /// DEKCOO.
        /// </summary>
        public const string DEKCOO = "DEKCOO";

        /// <summary>
        /// DESFXO.
        /// </summary>
        public const string DESFXO = "DESFXO";

        /// <summary>
        /// DELNID.
        /// </summary>
        public const string DELNID = "DELNID";

        /// <summary>
        /// DECO.
        /// </summary>
        public const string DECO = "DECO";

        /// <summary>
        /// DEMCU.
        /// </summary>
        public const string DEMCU = "DEMCU";

        /// <summary>
        /// DEAN8.
        /// </summary>
        public const string DEAN8 = "DEAN8";

        /// <summary>
        /// DEECST.
        /// </summary>
        public const string DEECST = "DEECST";

        /// <summary>
        /// DEAEXP.
        /// </summary>
        public const string DEAEXP = "DEAEXP";

        /// <summary>
        /// DEATXN.
        /// </summary>
        public const string DEATXN = "DEATXN";

        /// <summary>
        /// DEATXA.
        /// </summary>
        public const string DEATXA = "DEATXA";

        /// <summary>
        /// DESTAM.
        /// </summary>
        public const string DESTAM = "DESTAM";

        /// <summary>
        /// DETXA1.
        /// </summary>
        public const string DETXA1 = "DETXA1";

        /// <summary>
        /// DEEXR1.
        /// </summary>
        public const string DEEXR1 = "DEEXR1";

        /// <summary>
        /// DEEXR2.
        /// </summary>
        public const string DEEXR2 = "DEEXR2";

        /// <summary>
        /// DETRDJ.
        /// </summary>
        public const string DETRDJ = "DETRDJ";

        /// <summary>
        /// DEDGL.
        /// </summary>
        public const string DEDGL = "DEDGL";

        /// <summary>
        /// DEDSVJ.
        /// </summary>
        public const string DEDSVJ = "DEDSVJ";

        /// <summary>
        /// DELNTY.
        /// </summary>
        public const string DELNTY = "DELNTY";

        /// <summary>
        /// DEUORG.
        /// </summary>
        public const string DEUORG = "DEUORG";

        /// <summary>
        /// DEUOM.
        /// </summary>
        public const string DEUOM = "DEUOM";

        /// <summary>
        /// DEFVTY.
        /// </summary>
        public const string DEFVTY = "DEFVTY";

        /// <summary>
        /// DEPOST.
        /// </summary>
        public const string DEPOST = "DEPOST";

        /// <summary>
        /// DEICU.
        /// </summary>
        public const string DEICU = "DEICU";

        /// <summary>
        /// DEICUT.
        /// </summary>
        public const string DEICUT = "DEICUT";

        /// <summary>
        /// DEGDVL.
        /// </summary>
        public const string DEGDVL = "DEGDVL";

        /// <summary>
        /// DECRCD.
        /// </summary>
        public const string DECRCD = "DECRCD";

        /// <summary>
        /// DECRR.
        /// </summary>
        public const string DECRR = "DECRR";

        /// <summary>
        /// DEAG.
        /// </summary>
        public const string DEAG = "DEAG";

        /// <summary>
        /// DETAXE.
        /// </summary>
        public const string DETAXE = "DETAXE";

        /// <summary>
        /// DEDOC.
        /// </summary>
        public const string DEDOC = "DEDOC";

        /// <summary>
        /// DECRDC.
        /// </summary>
        public const string DECRDC = "DECRDC";

        /// <summary>
        /// DEURCD.
        /// </summary>
        public const string DEURCD = "DEURCD";

        /// <summary>
        /// DEURDT.
        /// </summary>
        public const string DEURDT = "DEURDT";

        /// <summary>
        /// DEURAT.
        /// </summary>
        public const string DEURAT = "DEURAT";

        /// <summary>
        /// DEURAB.
        /// </summary>
        public const string DEURAB = "DEURAB";

        /// <summary>
        /// DEURRF.
        /// </summary>
        public const string DEURRF = "DEURRF";

        /// <summary>
        /// DESHAN.
        /// </summary>
        public const string DESHAN = "DESHAN";

        /// <summary>
        /// DE74TRTY.
        /// </summary>
        public const string DE74TRTY = "DE74TRTY";

        /// <summary>
        /// DE74TRTN.
        /// </summary>
        public const string DE74TRTN = "DE74TRTN";

        /// <summary>
        /// DE74TRFG.
        /// </summary>
        public const string DE74TRFG = "DE74TRFG";

        /// <summary>
        /// DE74HMCU.
        /// </summary>
        public const string DE74HMCU = "DE74HMCU";

        /// <summary>
        /// DE74DMCU.
        /// </summary>
        public const string DE74DMCU = "DE74DMCU";

        /// <summary>
        /// DE74CTAX.
        /// </summary>
        public const string DE74CTAX = "DE74CTAX";

        /// <summary>
        /// DE74CCTR.
        /// </summary>
        public const string DE74CCTR = "DE74CCTR";

        /// <summary>
        /// DE74CVAT.
        /// </summary>
        public const string DE74CVAT = "DE74CVAT";

        /// <summary>
        /// DE74KTAX.
        /// </summary>
        public const string DE74KTAX = "DE74KTAX";

        /// <summary>
        /// DE74KCTR.
        /// </summary>
        public const string DE74KCTR = "DE74KCTR";

        /// <summary>
        /// DE74KVAT.
        /// </summary>
        public const string DE74KVAT = "DE74KVAT";

        /// <summary>
        /// DE74CACT.
        /// </summary>
        public const string DE74CACT = "DE74CACT";

        /// <summary>
        /// DE74KACT.
        /// </summary>
        public const string DE74KACT = "DE74KACT";

        /// <summary>
        /// DE74ICTR.
        /// </summary>
        public const string DE74ICTR = "DE74ICTR";

        /// <summary>
        /// DE74IACT.
        /// </summary>
        public const string DE74IACT = "DE74IACT";

        /// <summary>
        /// DE74TRAN.
        /// </summary>
        public const string DE74TRAN = "DE74TRAN";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";

        /// <summary>
        /// DEJOBN.
        /// </summary>
        public const string DEJOBN = "DEJOBN";

        /// <summary>
        /// DEUPMJ.
        /// </summary>
        public const string DEUPMJ = "DEUPMJ";

        /// <summary>
        /// DEUPMT.
        /// </summary>
        public const string DEUPMT = "DEUPMT";

        /// <summary>
        /// DEFFG1.
        /// </summary>
        public const string DEFFG1 = "DEFFG1";

        /// <summary>
        /// DEFFU4.
        /// </summary>
        public const string DEFFU4 = "DEFFU4";

        /// <summary>
        /// DEFUT5.
        /// </summary>
        public const string DEFUT5 = "DEFUT5";

        /// <summary>
        /// DEFUT3.
        /// </summary>
        public const string DEFUT3 = "DEFUT3";

        /// <summary>
        /// DEAA1.
        /// </summary>
        public const string DEAA1 = "DEAA1";

        /// <summary>
        /// DEAA2.
        /// </summary>
        public const string DEAA2 = "DEAA2";
    }

    /// <inheritdoc />
    public override string TableName => "F740018D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEDOCO", "DEDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DEDCTO", "DEDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DEKCOO", "DEKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DESFXO", "DESFXO", JdeDataType.String, 6, true, true),
        new JdeField("DELNID", "DELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DECO", "DECO", JdeDataType.String, 10),
        new JdeField("DEMCU", "DEMCU", JdeDataType.String, 24),
        new JdeField("DEAN8", "DEAN8", JdeDataType.Numeric),
        new JdeField("DEECST", "DEECST", JdeDataType.Numeric),
        new JdeField("DEAEXP", "DEAEXP", JdeDataType.Numeric),
        new JdeField("DEATXN", "DEATXN", JdeDataType.Numeric),
        new JdeField("DEATXA", "DEATXA", JdeDataType.Numeric),
        new JdeField("DESTAM", "DESTAM", JdeDataType.Numeric),
        new JdeField("DETXA1", "DETXA1", JdeDataType.String, 20),
        new JdeField("DEEXR1", "DEEXR1", JdeDataType.String, 4),
        new JdeField("DEEXR2", "DEEXR2", JdeDataType.String, 4),
        new JdeField("DETRDJ", "DETRDJ", JdeDataType.Numeric),
        new JdeField("DEDGL", "DEDGL", JdeDataType.Numeric),
        new JdeField("DEDSVJ", "DEDSVJ", JdeDataType.Numeric),
        new JdeField("DELNTY", "DELNTY", JdeDataType.String, 4),
        new JdeField("DEUORG", "DEUORG", JdeDataType.Numeric),
        new JdeField("DEUOM", "DEUOM", JdeDataType.String, 4),
        new JdeField("DEFVTY", "DEFVTY", JdeDataType.String, 2),
        new JdeField("DEPOST", "DEPOST", JdeDataType.String, 2),
        new JdeField("DEICU", "DEICU", JdeDataType.Numeric),
        new JdeField("DEICUT", "DEICUT", JdeDataType.String, 4),
        new JdeField("DEGDVL", "DEGDVL", JdeDataType.Numeric),
        new JdeField("DECRCD", "DECRCD", JdeDataType.String, 6),
        new JdeField("DECRR", "DECRR", JdeDataType.Numeric),
        new JdeField("DEAG", "DEAG", JdeDataType.Numeric),
        new JdeField("DETAXE", "DETAXE", JdeDataType.Numeric),
        new JdeField("DEDOC", "DEDOC", JdeDataType.Numeric),
        new JdeField("DECRDC", "DECRDC", JdeDataType.String, 6),
        new JdeField("DEURCD", "DEURCD", JdeDataType.String, 4),
        new JdeField("DEURDT", "DEURDT", JdeDataType.Numeric),
        new JdeField("DEURAT", "DEURAT", JdeDataType.Numeric),
        new JdeField("DEURAB", "DEURAB", JdeDataType.Numeric),
        new JdeField("DEURRF", "DEURRF", JdeDataType.String, 30),
        new JdeField("DESHAN", "DESHAN", JdeDataType.Numeric),
        new JdeField("DE74TRTY", "DE74TRTY", JdeDataType.String, 2),
        new JdeField("DE74TRTN", "DE74TRTN", JdeDataType.String, 2),
        new JdeField("DE74TRFG", "DE74TRFG", JdeDataType.String, 2),
        new JdeField("DE74HMCU", "DE74HMCU", JdeDataType.String, 24),
        new JdeField("DE74DMCU", "DE74DMCU", JdeDataType.String, 24),
        new JdeField("DE74CTAX", "DE74CTAX", JdeDataType.String, 40),
        new JdeField("DE74CCTR", "DE74CCTR", JdeDataType.String, 6),
        new JdeField("DE74CVAT", "DE74CVAT", JdeDataType.String, 40),
        new JdeField("DE74KTAX", "DE74KTAX", JdeDataType.String, 40),
        new JdeField("DE74KCTR", "DE74KCTR", JdeDataType.String, 6),
        new JdeField("DE74KVAT", "DE74KVAT", JdeDataType.String, 40),
        new JdeField("DE74CACT", "DE74CACT", JdeDataType.String, 6),
        new JdeField("DE74KACT", "DE74KACT", JdeDataType.String, 6),
        new JdeField("DE74ICTR", "DE74ICTR", JdeDataType.String, 6),
        new JdeField("DE74IACT", "DE74IACT", JdeDataType.String, 6),
        new JdeField("DE74TRAN", "DE74TRAN", JdeDataType.String, 60),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20),
        new JdeField("DEJOBN", "DEJOBN", JdeDataType.String, 20),
        new JdeField("DEUPMJ", "DEUPMJ", JdeDataType.Numeric),
        new JdeField("DEUPMT", "DEUPMT", JdeDataType.Numeric),
        new JdeField("DEFFG1", "DEFFG1", JdeDataType.String, 2),
        new JdeField("DEFFU4", "DEFFU4", JdeDataType.Numeric),
        new JdeField("DEFUT5", "DEFUT5", JdeDataType.String, 50),
        new JdeField("DEFUT3", "DEFUT3", JdeDataType.String, 60),
        new JdeField("DEAA1", "DEAA1", JdeDataType.Numeric),
        new JdeField("DEAA2", "DEAA2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740018D_0", "Primary Key on DEDOCO, DEDCTO, DEKCOO, DESFXO, DELNID", new[] { "DEDOCO", "DEDCTO", "DEKCOO", "DESFXO", "DELNID" }, isUnique: true, isPrimaryKey: true)
    };
}
