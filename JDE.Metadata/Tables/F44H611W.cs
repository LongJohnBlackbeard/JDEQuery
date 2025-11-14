using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H611W - .
/// </summary>
public class F44H611W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BWJOBS.
        /// </summary>
        public const string BWJOBS = "BWJOBS";

        /// <summary>
        /// BWKCOO.
        /// </summary>
        public const string BWKCOO = "BWKCOO";

        /// <summary>
        /// BWDOCO.
        /// </summary>
        public const string BWDOCO = "BWDOCO";

        /// <summary>
        /// BWDCTO.
        /// </summary>
        public const string BWDCTO = "BWDCTO";

        /// <summary>
        /// BWSFXO.
        /// </summary>
        public const string BWSFXO = "BWSFXO";

        /// <summary>
        /// BWLNID.
        /// </summary>
        public const string BWLNID = "BWLNID";

        /// <summary>
        /// BWOKCO.
        /// </summary>
        public const string BWOKCO = "BWOKCO";

        /// <summary>
        /// BWODOC.
        /// </summary>
        public const string BWODOC = "BWODOC";

        /// <summary>
        /// BWOCTO.
        /// </summary>
        public const string BWOCTO = "BWOCTO";

        /// <summary>
        /// BWHBAREA.
        /// </summary>
        public const string BWHBAREA = "BWHBAREA";

        /// <summary>
        /// BWMCU.
        /// </summary>
        public const string BWMCU = "BWMCU";

        /// <summary>
        /// BWANI.
        /// </summary>
        public const string BWANI = "BWANI";

        /// <summary>
        /// BWAID.
        /// </summary>
        public const string BWAID = "BWAID";

        /// <summary>
        /// BWCPHASE.
        /// </summary>
        public const string BWCPHASE = "BWCPHASE";

        /// <summary>
        /// BWOBJ.
        /// </summary>
        public const string BWOBJ = "BWOBJ";

        /// <summary>
        /// BWSUB.
        /// </summary>
        public const string BWSUB = "BWSUB";

        /// <summary>
        /// BWOPTION.
        /// </summary>
        public const string BWOPTION = "BWOPTION";

        /// <summary>
        /// BWHBPLAN.
        /// </summary>
        public const string BWHBPLAN = "BWHBPLAN";

        /// <summary>
        /// BWHBELEV.
        /// </summary>
        public const string BWHBELEV = "BWHBELEV";

        /// <summary>
        /// BWR001.
        /// </summary>
        public const string BWR001 = "BWR001";

        /// <summary>
        /// BWBIDTYPE.
        /// </summary>
        public const string BWBIDTYPE = "BWBIDTYPE";

        /// <summary>
        /// BWVNDAOVR.
        /// </summary>
        public const string BWVNDAOVR = "BWVNDAOVR";

        /// <summary>
        /// BWUNIDOC.
        /// </summary>
        public const string BWUNIDOC = "BWUNIDOC";

        /// <summary>
        /// BWBUDONLY.
        /// </summary>
        public const string BWBUDONLY = "BWBUDONLY";

        /// <summary>
        /// BWVNDTBD.
        /// </summary>
        public const string BWVNDTBD = "BWVNDTBD";

        /// <summary>
        /// BWAVEL.
        /// </summary>
        public const string BWAVEL = "BWAVEL";

        /// <summary>
        /// BWAN8.
        /// </summary>
        public const string BWAN8 = "BWAN8";

        /// <summary>
        /// BWSHAN.
        /// </summary>
        public const string BWSHAN = "BWSHAN";

        /// <summary>
        /// BWDGL.
        /// </summary>
        public const string BWDGL = "BWDGL";

        /// <summary>
        /// BWBDEFDT.
        /// </summary>
        public const string BWBDEFDT = "BWBDEFDT";

        /// <summary>
        /// BWBDCLDT.
        /// </summary>
        public const string BWBDCLDT = "BWBDCLDT";

        /// <summary>
        /// BWPDDJ.
        /// </summary>
        public const string BWPDDJ = "BWPDDJ";

        /// <summary>
        /// BWOPDJ.
        /// </summary>
        public const string BWOPDJ = "BWOPDJ";

        /// <summary>
        /// BWTRDJ.
        /// </summary>
        public const string BWTRDJ = "BWTRDJ";

        /// <summary>
        /// BWPN.
        /// </summary>
        public const string BWPN = "BWPN";

        /// <summary>
        /// BWVR01.
        /// </summary>
        public const string BWVR01 = "BWVR01";

        /// <summary>
        /// BWVR02.
        /// </summary>
        public const string BWVR02 = "BWVR02";

        /// <summary>
        /// BWITM.
        /// </summary>
        public const string BWITM = "BWITM";

        /// <summary>
        /// BWLITM.
        /// </summary>
        public const string BWLITM = "BWLITM";

        /// <summary>
        /// BWDSC1.
        /// </summary>
        public const string BWDSC1 = "BWDSC1";

        /// <summary>
        /// BWDSC2.
        /// </summary>
        public const string BWDSC2 = "BWDSC2";

        /// <summary>
        /// BWLNTY.
        /// </summary>
        public const string BWLNTY = "BWLNTY";

        /// <summary>
        /// BWNXTR.
        /// </summary>
        public const string BWNXTR = "BWNXTR";

        /// <summary>
        /// BWLTTR.
        /// </summary>
        public const string BWLTTR = "BWLTTR";

        /// <summary>
        /// BWPDP1.
        /// </summary>
        public const string BWPDP1 = "BWPDP1";

        /// <summary>
        /// BWPDP2.
        /// </summary>
        public const string BWPDP2 = "BWPDP2";

        /// <summary>
        /// BWPDP3.
        /// </summary>
        public const string BWPDP3 = "BWPDP3";

        /// <summary>
        /// BWPDP4.
        /// </summary>
        public const string BWPDP4 = "BWPDP4";

        /// <summary>
        /// BWPDP5.
        /// </summary>
        public const string BWPDP5 = "BWPDP5";

        /// <summary>
        /// BWUOM.
        /// </summary>
        public const string BWUOM = "BWUOM";

        /// <summary>
        /// BWPRRC.
        /// </summary>
        public const string BWPRRC = "BWPRRC";

        /// <summary>
        /// BWUORG.
        /// </summary>
        public const string BWUORG = "BWUORG";

        /// <summary>
        /// BWAEXP.
        /// </summary>
        public const string BWAEXP = "BWAEXP";

        /// <summary>
        /// BWPERFCTR.
        /// </summary>
        public const string BWPERFCTR = "BWPERFCTR";

        /// <summary>
        /// BWFTN1.
        /// </summary>
        public const string BWFTN1 = "BWFTN1";

        /// <summary>
        /// BWPTC.
        /// </summary>
        public const string BWPTC = "BWPTC";

        /// <summary>
        /// BWTX.
        /// </summary>
        public const string BWTX = "BWTX";

        /// <summary>
        /// BWEXR1.
        /// </summary>
        public const string BWEXR1 = "BWEXR1";

        /// <summary>
        /// BWTXA1.
        /// </summary>
        public const string BWTXA1 = "BWTXA1";

        /// <summary>
        /// BWANBY.
        /// </summary>
        public const string BWANBY = "BWANBY";

        /// <summary>
        /// BWGLC.
        /// </summary>
        public const string BWGLC = "BWGLC";

        /// <summary>
        /// BWCTRY.
        /// </summary>
        public const string BWCTRY = "BWCTRY";

        /// <summary>
        /// BWFY.
        /// </summary>
        public const string BWFY = "BWFY";

        /// <summary>
        /// BWRCD.
        /// </summary>
        public const string BWRCD = "BWRCD";

        /// <summary>
        /// BWFUF1.
        /// </summary>
        public const string BWFUF1 = "BWFUF1";

        /// <summary>
        /// BWFUF2.
        /// </summary>
        public const string BWFUF2 = "BWFUF2";

        /// <summary>
        /// BWLT.
        /// </summary>
        public const string BWLT = "BWLT";

        /// <summary>
        /// BWPCRT.
        /// </summary>
        public const string BWPCRT = "BWPCRT";

        /// <summary>
        /// BWRTNR.
        /// </summary>
        public const string BWRTNR = "BWRTNR";

        /// <summary>
        /// BWPURG.
        /// </summary>
        public const string BWPURG = "BWPURG";

        /// <summary>
        /// BWCRRM.
        /// </summary>
        public const string BWCRRM = "BWCRRM";

        /// <summary>
        /// BWCRCD.
        /// </summary>
        public const string BWCRCD = "BWCRCD";

        /// <summary>
        /// BWCRR.
        /// </summary>
        public const string BWCRR = "BWCRR";

        /// <summary>
        /// BWFRRC.
        /// </summary>
        public const string BWFRRC = "BWFRRC";

        /// <summary>
        /// BWFEA.
        /// </summary>
        public const string BWFEA = "BWFEA";

        /// <summary>
        /// BWFUC.
        /// </summary>
        public const string BWFUC = "BWFUC";

        /// <summary>
        /// BWFEC.
        /// </summary>
        public const string BWFEC = "BWFEC";

        /// <summary>
        /// BWHBST1.
        /// </summary>
        public const string BWHBST1 = "BWHBST1";

        /// <summary>
        /// BWHBST2.
        /// </summary>
        public const string BWHBST2 = "BWHBST2";

        /// <summary>
        /// BWHBST3.
        /// </summary>
        public const string BWHBST3 = "BWHBST3";

        /// <summary>
        /// BWHBST4.
        /// </summary>
        public const string BWHBST4 = "BWHBST4";

        /// <summary>
        /// BWHBST5.
        /// </summary>
        public const string BWHBST5 = "BWHBST5";

        /// <summary>
        /// BWURRF.
        /// </summary>
        public const string BWURRF = "BWURRF";

        /// <summary>
        /// BWCRTU.
        /// </summary>
        public const string BWCRTU = "BWCRTU";

        /// <summary>
        /// BWCRTJ.
        /// </summary>
        public const string BWCRTJ = "BWCRTJ";

        /// <summary>
        /// BWCRTT.
        /// </summary>
        public const string BWCRTT = "BWCRTT";

        /// <summary>
        /// BWWRKSTNID.
        /// </summary>
        public const string BWWRKSTNID = "BWWRKSTNID";

        /// <summary>
        /// BWHBOPID.
        /// </summary>
        public const string BWHBOPID = "BWHBOPID";

        /// <summary>
        /// BWUPMB.
        /// </summary>
        public const string BWUPMB = "BWUPMB";

        /// <summary>
        /// BWUPMJ.
        /// </summary>
        public const string BWUPMJ = "BWUPMJ";

        /// <summary>
        /// BWUPMT.
        /// </summary>
        public const string BWUPMT = "BWUPMT";

        /// <summary>
        /// BWJOBN.
        /// </summary>
        public const string BWJOBN = "BWJOBN";

        /// <summary>
        /// BWPID.
        /// </summary>
        public const string BWPID = "BWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H611W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BWJOBS", "BWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BWKCOO", "BWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("BWDOCO", "BWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("BWDCTO", "BWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("BWSFXO", "BWSFXO", JdeDataType.String, 6, true, true),
        new JdeField("BWLNID", "BWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BWOKCO", "BWOKCO", JdeDataType.String, 10),
        new JdeField("BWODOC", "BWODOC", JdeDataType.Numeric),
        new JdeField("BWOCTO", "BWOCTO", JdeDataType.String, 4),
        new JdeField("BWHBAREA", "BWHBAREA", JdeDataType.String, 6),
        new JdeField("BWMCU", "BWMCU", JdeDataType.String, 24),
        new JdeField("BWANI", "BWANI", JdeDataType.String, 58),
        new JdeField("BWAID", "BWAID", JdeDataType.String, 16),
        new JdeField("BWCPHASE", "BWCPHASE", JdeDataType.String, 6),
        new JdeField("BWOBJ", "BWOBJ", JdeDataType.String, 12),
        new JdeField("BWSUB", "BWSUB", JdeDataType.String, 16),
        new JdeField("BWOPTION", "BWOPTION", JdeDataType.String, 16),
        new JdeField("BWHBPLAN", "BWHBPLAN", JdeDataType.String, 8),
        new JdeField("BWHBELEV", "BWHBELEV", JdeDataType.String, 6),
        new JdeField("BWR001", "BWR001", JdeDataType.String, 6),
        new JdeField("BWBIDTYPE", "BWBIDTYPE", JdeDataType.String, 4),
        new JdeField("BWVNDAOVR", "BWVNDAOVR", JdeDataType.String, 2),
        new JdeField("BWUNIDOC", "BWUNIDOC", JdeDataType.String, 2),
        new JdeField("BWBUDONLY", "BWBUDONLY", JdeDataType.String, 2),
        new JdeField("BWVNDTBD", "BWVNDTBD", JdeDataType.String, 2),
        new JdeField("BWAVEL", "BWAVEL", JdeDataType.String, 2),
        new JdeField("BWAN8", "BWAN8", JdeDataType.Numeric),
        new JdeField("BWSHAN", "BWSHAN", JdeDataType.Numeric),
        new JdeField("BWDGL", "BWDGL", JdeDataType.Numeric),
        new JdeField("BWBDEFDT", "BWBDEFDT", JdeDataType.Numeric),
        new JdeField("BWBDCLDT", "BWBDCLDT", JdeDataType.Numeric),
        new JdeField("BWPDDJ", "BWPDDJ", JdeDataType.Numeric),
        new JdeField("BWOPDJ", "BWOPDJ", JdeDataType.Numeric),
        new JdeField("BWTRDJ", "BWTRDJ", JdeDataType.Numeric),
        new JdeField("BWPN", "BWPN", JdeDataType.Numeric),
        new JdeField("BWVR01", "BWVR01", JdeDataType.String, 50),
        new JdeField("BWVR02", "BWVR02", JdeDataType.String, 50),
        new JdeField("BWITM", "BWITM", JdeDataType.Numeric),
        new JdeField("BWLITM", "BWLITM", JdeDataType.String, 50),
        new JdeField("BWDSC1", "BWDSC1", JdeDataType.String, 60),
        new JdeField("BWDSC2", "BWDSC2", JdeDataType.String, 60),
        new JdeField("BWLNTY", "BWLNTY", JdeDataType.String, 4),
        new JdeField("BWNXTR", "BWNXTR", JdeDataType.String, 6),
        new JdeField("BWLTTR", "BWLTTR", JdeDataType.String, 6),
        new JdeField("BWPDP1", "BWPDP1", JdeDataType.String, 6),
        new JdeField("BWPDP2", "BWPDP2", JdeDataType.String, 6),
        new JdeField("BWPDP3", "BWPDP3", JdeDataType.String, 6),
        new JdeField("BWPDP4", "BWPDP4", JdeDataType.String, 6),
        new JdeField("BWPDP5", "BWPDP5", JdeDataType.String, 6),
        new JdeField("BWUOM", "BWUOM", JdeDataType.String, 4),
        new JdeField("BWPRRC", "BWPRRC", JdeDataType.Numeric),
        new JdeField("BWUORG", "BWUORG", JdeDataType.Numeric),
        new JdeField("BWAEXP", "BWAEXP", JdeDataType.Numeric),
        new JdeField("BWPERFCTR", "BWPERFCTR", JdeDataType.Numeric),
        new JdeField("BWFTN1", "BWFTN1", JdeDataType.Numeric),
        new JdeField("BWPTC", "BWPTC", JdeDataType.String, 6),
        new JdeField("BWTX", "BWTX", JdeDataType.String, 2),
        new JdeField("BWEXR1", "BWEXR1", JdeDataType.String, 4),
        new JdeField("BWTXA1", "BWTXA1", JdeDataType.String, 20),
        new JdeField("BWANBY", "BWANBY", JdeDataType.Numeric),
        new JdeField("BWGLC", "BWGLC", JdeDataType.String, 8),
        new JdeField("BWCTRY", "BWCTRY", JdeDataType.Numeric),
        new JdeField("BWFY", "BWFY", JdeDataType.Numeric),
        new JdeField("BWRCD", "BWRCD", JdeDataType.String, 6),
        new JdeField("BWFUF1", "BWFUF1", JdeDataType.String, 2),
        new JdeField("BWFUF2", "BWFUF2", JdeDataType.String, 2),
        new JdeField("BWLT", "BWLT", JdeDataType.String, 4),
        new JdeField("BWPCRT", "BWPCRT", JdeDataType.Numeric),
        new JdeField("BWRTNR", "BWRTNR", JdeDataType.String, 6),
        new JdeField("BWPURG", "BWPURG", JdeDataType.String, 2),
        new JdeField("BWCRRM", "BWCRRM", JdeDataType.String, 2),
        new JdeField("BWCRCD", "BWCRCD", JdeDataType.String, 6),
        new JdeField("BWCRR", "BWCRR", JdeDataType.Numeric),
        new JdeField("BWFRRC", "BWFRRC", JdeDataType.Numeric),
        new JdeField("BWFEA", "BWFEA", JdeDataType.Numeric),
        new JdeField("BWFUC", "BWFUC", JdeDataType.Numeric),
        new JdeField("BWFEC", "BWFEC", JdeDataType.Numeric),
        new JdeField("BWHBST1", "BWHBST1", JdeDataType.String, 2),
        new JdeField("BWHBST2", "BWHBST2", JdeDataType.String, 2),
        new JdeField("BWHBST3", "BWHBST3", JdeDataType.String, 2),
        new JdeField("BWHBST4", "BWHBST4", JdeDataType.String, 2),
        new JdeField("BWHBST5", "BWHBST5", JdeDataType.String, 2),
        new JdeField("BWURRF", "BWURRF", JdeDataType.String, 30),
        new JdeField("BWCRTU", "BWCRTU", JdeDataType.String, 20),
        new JdeField("BWCRTJ", "BWCRTJ", JdeDataType.Numeric),
        new JdeField("BWCRTT", "BWCRTT", JdeDataType.Numeric),
        new JdeField("BWWRKSTNID", "BWWRKSTNID", JdeDataType.String, 20),
        new JdeField("BWHBOPID", "BWHBOPID", JdeDataType.String, 20),
        new JdeField("BWUPMB", "BWUPMB", JdeDataType.String, 20),
        new JdeField("BWUPMJ", "BWUPMJ", JdeDataType.Numeric),
        new JdeField("BWUPMT", "BWUPMT", JdeDataType.Numeric),
        new JdeField("BWJOBN", "BWJOBN", JdeDataType.String, 20),
        new JdeField("BWPID", "BWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H611W_0", "Primary Key on BWJOBS, BWKCOO, BWDOCO, BWDCTO, BWSFXO, BWLNID", new[] { "BWJOBS", "BWKCOO", "BWDOCO", "BWDCTO", "BWSFXO", "BWLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H611W_2", "Index on BWJOBS, BWDOCO, BWDCTO, BWKCOO, SYS_NC00094$, SYS_NC00095$", new[] { "BWJOBS", "BWDOCO", "BWDCTO", "BWKCOO", "SYS_NC00094$", "SYS_NC00095$" }),
        new JdeIndex("F44H611W_3", "Index on BWJOBS, BWOKCO, BWODOC, BWOCTO", new[] { "BWJOBS", "BWOKCO", "BWODOC", "BWOCTO" })
    };
}
