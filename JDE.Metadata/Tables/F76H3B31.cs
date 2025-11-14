using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B31 - .
/// </summary>
public class F76H3B31 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PIPTC.
        /// </summary>
        public const string PIPTC = "PIPTC";

        /// <summary>
        /// PIEFDJ.
        /// </summary>
        public const string PIEFDJ = "PIEFDJ";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIALPH.
        /// </summary>
        public const string PIALPH = "PIALPH";

        /// <summary>
        /// PIADD1.
        /// </summary>
        public const string PIADD1 = "PIADD1";

        /// <summary>
        /// PIADD2.
        /// </summary>
        public const string PIADD2 = "PIADD2";

        /// <summary>
        /// PIADD3.
        /// </summary>
        public const string PIADD3 = "PIADD3";

        /// <summary>
        /// PIADD4.
        /// </summary>
        public const string PIADD4 = "PIADD4";

        /// <summary>
        /// PICTY1.
        /// </summary>
        public const string PICTY1 = "PICTY1";

        /// <summary>
        /// PICOUN.
        /// </summary>
        public const string PICOUN = "PICOUN";

        /// <summary>
        /// PIADDS.
        /// </summary>
        public const string PIADDS = "PIADDS";

        /// <summary>
        /// PIADDZ.
        /// </summary>
        public const string PIADDZ = "PIADDZ";

        /// <summary>
        /// PICTR.
        /// </summary>
        public const string PICTR = "PICTR";

        /// <summary>
        /// PIDL01.
        /// </summary>
        public const string PIDL01 = "PIDL01";

        /// <summary>
        /// PIPH1.
        /// </summary>
        public const string PIPH1 = "PIPH1";

        /// <summary>
        /// PITAX.
        /// </summary>
        public const string PITAX = "PITAX";

        /// <summary>
        /// PISHAN.
        /// </summary>
        public const string PISHAN = "PISHAN";

        /// <summary>
        /// PIALPH1.
        /// </summary>
        public const string PIALPH1 = "PIALPH1";

        /// <summary>
        /// PISHL1.
        /// </summary>
        public const string PISHL1 = "PISHL1";

        /// <summary>
        /// PISHL2.
        /// </summary>
        public const string PISHL2 = "PISHL2";

        /// <summary>
        /// PISHL3.
        /// </summary>
        public const string PISHL3 = "PISHL3";

        /// <summary>
        /// PISHL4.
        /// </summary>
        public const string PISHL4 = "PISHL4";

        /// <summary>
        /// PIVSTCT.
        /// </summary>
        public const string PIVSTCT = "PIVSTCT";

        /// <summary>
        /// PIVSTCN.
        /// </summary>
        public const string PIVSTCN = "PIVSTCN";

        /// <summary>
        /// PIVSTST.
        /// </summary>
        public const string PIVSTST = "PIVSTST";

        /// <summary>
        /// PISHZP.
        /// </summary>
        public const string PISHZP = "PISHZP";

        /// <summary>
        /// PICTR2.
        /// </summary>
        public const string PICTR2 = "PICTR2";

        /// <summary>
        /// PIPH2.
        /// </summary>
        public const string PIPH2 = "PIPH2";

        /// <summary>
        /// PITAXX.
        /// </summary>
        public const string PITAXX = "PITAXX";

        /// <summary>
        /// PICRRM.
        /// </summary>
        public const string PICRRM = "PICRRM";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PICRR.
        /// </summary>
        public const string PICRR = "PICRR";

        /// <summary>
        /// PIATXA.
        /// </summary>
        public const string PIATXA = "PIATXA";

        /// <summary>
        /// PIATXN.
        /// </summary>
        public const string PIATXN = "PIATXN";

        /// <summary>
        /// PISTAM.
        /// </summary>
        public const string PISTAM = "PISTAM";

        /// <summary>
        /// PIAG.
        /// </summary>
        public const string PIAG = "PIAG";

        /// <summary>
        /// PIWTUM.
        /// </summary>
        public const string PIWTUM = "PIWTUM";

        /// <summary>
        /// PIITWT.
        /// </summary>
        public const string PIITWT = "PIITWT";

        /// <summary>
        /// PIVLUM.
        /// </summary>
        public const string PIVLUM = "PIVLUM";

        /// <summary>
        /// PIITVL.
        /// </summary>
        public const string PIITVL = "PIITVL";

        /// <summary>
        /// PIMGTX.
        /// </summary>
        public const string PIMGTX = "PIMGTX";

        /// <summary>
        /// PIDEL1.
        /// </summary>
        public const string PIDEL1 = "PIDEL1";

        /// <summary>
        /// PIDEL2.
        /// </summary>
        public const string PIDEL2 = "PIDEL2";

        /// <summary>
        /// PICARS.
        /// </summary>
        public const string PICARS = "PICARS";

        /// <summary>
        /// PIALPHNM.
        /// </summary>
        public const string PIALPHNM = "PIALPHNM";

        /// <summary>
        /// PIADD5.
        /// </summary>
        public const string PIADD5 = "PIADD5";

        /// <summary>
        /// PIADD6.
        /// </summary>
        public const string PIADD6 = "PIADD6";

        /// <summary>
        /// PIADD7.
        /// </summary>
        public const string PIADD7 = "PIADD7";

        /// <summary>
        /// PIADD8.
        /// </summary>
        public const string PIADD8 = "PIADD8";

        /// <summary>
        /// PICTYNH2.
        /// </summary>
        public const string PICTYNH2 = "PICTYNH2";

        /// <summary>
        /// PICOUNNH2.
        /// </summary>
        public const string PICOUNNH2 = "PICOUNNH2";

        /// <summary>
        /// PIADDSNH2.
        /// </summary>
        public const string PIADDSNH2 = "PIADDSNH2";

        /// <summary>
        /// PIADDZNH2.
        /// </summary>
        public const string PIADDZNH2 = "PIADDZNH2";

        /// <summary>
        /// PICTR4.
        /// </summary>
        public const string PICTR4 = "PICTR4";

        /// <summary>
        /// PIPH3.
        /// </summary>
        public const string PIPH3 = "PIPH3";

        /// <summary>
        /// PITAXX2.
        /// </summary>
        public const string PITAXX2 = "PITAXX2";

        /// <summary>
        /// PITORG.
        /// </summary>
        public const string PITORG = "PITORG";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B31";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIPTC", "PIPTC", JdeDataType.String, 6),
        new JdeField("PIEFDJ", "PIEFDJ", JdeDataType.Numeric),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric),
        new JdeField("PIALPH", "PIALPH", JdeDataType.String, 80),
        new JdeField("PIADD1", "PIADD1", JdeDataType.String, 80),
        new JdeField("PIADD2", "PIADD2", JdeDataType.String, 80),
        new JdeField("PIADD3", "PIADD3", JdeDataType.String, 80),
        new JdeField("PIADD4", "PIADD4", JdeDataType.String, 80),
        new JdeField("PICTY1", "PICTY1", JdeDataType.String, 50),
        new JdeField("PICOUN", "PICOUN", JdeDataType.String, 50),
        new JdeField("PIADDS", "PIADDS", JdeDataType.String, 6),
        new JdeField("PIADDZ", "PIADDZ", JdeDataType.String, 24),
        new JdeField("PICTR", "PICTR", JdeDataType.String, 6),
        new JdeField("PIDL01", "PIDL01", JdeDataType.String, 60),
        new JdeField("PIPH1", "PIPH1", JdeDataType.String, 40),
        new JdeField("PITAX", "PITAX", JdeDataType.String, 40),
        new JdeField("PISHAN", "PISHAN", JdeDataType.Numeric),
        new JdeField("PIALPH1", "PIALPH1", JdeDataType.String, 80),
        new JdeField("PISHL1", "PISHL1", JdeDataType.String, 80),
        new JdeField("PISHL2", "PISHL2", JdeDataType.String, 80),
        new JdeField("PISHL3", "PISHL3", JdeDataType.String, 80),
        new JdeField("PISHL4", "PISHL4", JdeDataType.String, 80),
        new JdeField("PIVSTCT", "PIVSTCT", JdeDataType.String, 50),
        new JdeField("PIVSTCN", "PIVSTCN", JdeDataType.String, 50),
        new JdeField("PIVSTST", "PIVSTST", JdeDataType.String, 6),
        new JdeField("PISHZP", "PISHZP", JdeDataType.String, 24),
        new JdeField("PICTR2", "PICTR2", JdeDataType.String, 6),
        new JdeField("PIPH2", "PIPH2", JdeDataType.String, 40),
        new JdeField("PITAXX", "PITAXX", JdeDataType.String, 40),
        new JdeField("PICRRM", "PICRRM", JdeDataType.String, 2),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PICRR", "PICRR", JdeDataType.Numeric),
        new JdeField("PIATXA", "PIATXA", JdeDataType.Numeric),
        new JdeField("PIATXN", "PIATXN", JdeDataType.Numeric),
        new JdeField("PISTAM", "PISTAM", JdeDataType.Numeric),
        new JdeField("PIAG", "PIAG", JdeDataType.Numeric),
        new JdeField("PIWTUM", "PIWTUM", JdeDataType.String, 4),
        new JdeField("PIITWT", "PIITWT", JdeDataType.Numeric),
        new JdeField("PIVLUM", "PIVLUM", JdeDataType.String, 4),
        new JdeField("PIITVL", "PIITVL", JdeDataType.Numeric),
        new JdeField("PIMGTX", "PIMGTX", JdeDataType.String, 400),
        new JdeField("PIDEL1", "PIDEL1", JdeDataType.String, 60),
        new JdeField("PIDEL2", "PIDEL2", JdeDataType.String, 60),
        new JdeField("PICARS", "PICARS", JdeDataType.Numeric),
        new JdeField("PIALPHNM", "PIALPHNM", JdeDataType.String, 80),
        new JdeField("PIADD5", "PIADD5", JdeDataType.String, 80),
        new JdeField("PIADD6", "PIADD6", JdeDataType.String, 80),
        new JdeField("PIADD7", "PIADD7", JdeDataType.String, 80),
        new JdeField("PIADD8", "PIADD8", JdeDataType.String, 80),
        new JdeField("PICTYNH2", "PICTYNH2", JdeDataType.String, 50),
        new JdeField("PICOUNNH2", "PICOUNNH2", JdeDataType.String, 50),
        new JdeField("PIADDSNH2", "PIADDSNH2", JdeDataType.String, 6),
        new JdeField("PIADDZNH2", "PIADDZNH2", JdeDataType.String, 24),
        new JdeField("PICTR4", "PICTR4", JdeDataType.String, 6),
        new JdeField("PIPH3", "PIPH3", JdeDataType.String, 40),
        new JdeField("PITAXX2", "PITAXX2", JdeDataType.String, 40),
        new JdeField("PITORG", "PITORG", JdeDataType.String, 20),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B31_0", "Primary Key on PIKCO, PIDCT, PIDOC", new[] { "PIKCO", "PIDCT", "PIDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
