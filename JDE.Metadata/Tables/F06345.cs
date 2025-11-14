using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06345 - .
/// </summary>
public class F06345 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLAN8.
        /// </summary>
        public const string JLAN8 = "JLAN8";

        /// <summary>
        /// JLRC.
        /// </summary>
        public const string JLRC = "JLRC";

        /// <summary>
        /// JLCKCN.
        /// </summary>
        public const string JLCKCN = "JLCKCN";

        /// <summary>
        /// JLSCKC.
        /// </summary>
        public const string JLSCKC = "JLSCKC";

        /// <summary>
        /// JLPALF.
        /// </summary>
        public const string JLPALF = "JLPALF";

        /// <summary>
        /// JLHMCO.
        /// </summary>
        public const string JLHMCO = "JLHMCO";

        /// <summary>
        /// JLHMCU.
        /// </summary>
        public const string JLHMCU = "JLHMCU";

        /// <summary>
        /// JLMAIL.
        /// </summary>
        public const string JLMAIL = "JLMAIL";

        /// <summary>
        /// JLSG.
        /// </summary>
        public const string JLSG = "JLSG";

        /// <summary>
        /// JLUN.
        /// </summary>
        public const string JLUN = "JLUN";

        /// <summary>
        /// JLJBCD.
        /// </summary>
        public const string JLJBCD = "JLJBCD";

        /// <summary>
        /// JLJBST.
        /// </summary>
        public const string JLJBST = "JLJBST";

        /// <summary>
        /// JLP001.
        /// </summary>
        public const string JLP001 = "JLP001";

        /// <summary>
        /// JLP002.
        /// </summary>
        public const string JLP002 = "JLP002";

        /// <summary>
        /// JLP003.
        /// </summary>
        public const string JLP003 = "JLP003";

        /// <summary>
        /// JLP004.
        /// </summary>
        public const string JLP004 = "JLP004";

        /// <summary>
        /// JLICC.
        /// </summary>
        public const string JLICC = "JLICC";

        /// <summary>
        /// JLICS.
        /// </summary>
        public const string JLICS = "JLICS";

        /// <summary>
        /// JLGLBA.
        /// </summary>
        public const string JLGLBA = "JLGLBA";

        /// <summary>
        /// JLDOCM.
        /// </summary>
        public const string JLDOCM = "JLDOCM";

        /// <summary>
        /// JLCKDT.
        /// </summary>
        public const string JLCKDT = "JLCKDT";

        /// <summary>
        /// JLPPED.
        /// </summary>
        public const string JLPPED = "JLPPED";

        /// <summary>
        /// JLPDBA.
        /// </summary>
        public const string JLPDBA = "JLPDBA";

        /// <summary>
        /// JLDISO.
        /// </summary>
        public const string JLDISO = "JLDISO";

        /// <summary>
        /// JLPCK.
        /// </summary>
        public const string JLPCK = "JLPCK";

        /// <summary>
        /// JLPTCT.
        /// </summary>
        public const string JLPTCT = "JLPTCT";

        /// <summary>
        /// JLPAYG.
        /// </summary>
        public const string JLPAYG = "JLPAYG";

        /// <summary>
        /// JLPAYN.
        /// </summary>
        public const string JLPAYN = "JLPAYN";

        /// <summary>
        /// JLTARA.
        /// </summary>
        public const string JLTARA = "JLTARA";

        /// <summary>
        /// JLPTAX.
        /// </summary>
        public const string JLPTAX = "JLPTAX";

        /// <summary>
        /// JLCE.
        /// </summary>
        public const string JLCE = "JLCE";

        /// <summary>
        /// JLNPAY.
        /// </summary>
        public const string JLNPAY = "JLNPAY";

        /// <summary>
        /// JLNPY1.
        /// </summary>
        public const string JLNPY1 = "JLNPY1";

        /// <summary>
        /// JLIFO#.
        /// </summary>
        public const string JLIFO_ = "JLIFO#";

        /// <summary>
        /// JLFOA#.
        /// </summary>
        public const string JLFOA_ = "JLFOA#";

        /// <summary>
        /// JLNPY2.
        /// </summary>
        public const string JLNPY2 = "JLNPY2";

        /// <summary>
        /// JLHRW.
        /// </summary>
        public const string JLHRW = "JLHRW";

        /// <summary>
        /// JLHYTD.
        /// </summary>
        public const string JLHYTD = "JLHYTD";

        /// <summary>
        /// JLUNPC.
        /// </summary>
        public const string JLUNPC = "JLUNPC";

        /// <summary>
        /// JLBIPY.
        /// </summary>
        public const string JLBIPY = "JLBIPY";

        /// <summary>
        /// JLPHRT.
        /// </summary>
        public const string JLPHRT = "JLPHRT";

        /// <summary>
        /// JLBHRT.
        /// </summary>
        public const string JLBHRT = "JLBHRT";

        /// <summary>
        /// JLSHRT.
        /// </summary>
        public const string JLSHRT = "JLSHRT";

        /// <summary>
        /// JLPPRT.
        /// </summary>
        public const string JLPPRT = "JLPPRT";

        /// <summary>
        /// JLGPAY.
        /// </summary>
        public const string JLGPAY = "JLGPAY";

        /// <summary>
        /// JLG101.
        /// </summary>
        public const string JLG101 = "JLG101";

        /// <summary>
        /// JLYTDG.
        /// </summary>
        public const string JLYTDG = "JLYTDG";

        /// <summary>
        /// JLG201.
        /// </summary>
        public const string JLG201 = "JLG201";

        /// <summary>
        /// JLYTDE.
        /// </summary>
        public const string JLYTDE = "JLYTDE";

        /// <summary>
        /// JLG401.
        /// </summary>
        public const string JLG401 = "JLG401";

        /// <summary>
        /// JLYTIE.
        /// </summary>
        public const string JLYTIE = "JLYTIE";

        /// <summary>
        /// JLG301.
        /// </summary>
        public const string JLG301 = "JLG301";

        /// <summary>
        /// JLYTDT.
        /// </summary>
        public const string JLYTDT = "JLYTDT";

        /// <summary>
        /// JLRCND.
        /// </summary>
        public const string JLRCND = "JLRCND";

        /// <summary>
        /// JLCLDT.
        /// </summary>
        public const string JLCLDT = "JLCLDT";

        /// <summary>
        /// JLDOCS.
        /// </summary>
        public const string JLDOCS = "JLDOCS";

        /// <summary>
        /// JLDOCP.
        /// </summary>
        public const string JLDOCP = "JLDOCP";

        /// <summary>
        /// JLREDT.
        /// </summary>
        public const string JLREDT = "JLREDT";
    }

    /// <inheritdoc />
    public override string TableName => "F06345";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLAN8", "JLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JLRC", "JLRC", JdeDataType.String, 2, true, true),
        new JdeField("JLCKCN", "JLCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("JLSCKC", "JLSCKC", JdeDataType.Numeric),
        new JdeField("JLPALF", "JLPALF", JdeDataType.String, 24),
        new JdeField("JLHMCO", "JLHMCO", JdeDataType.String, 10),
        new JdeField("JLHMCU", "JLHMCU", JdeDataType.String, 24),
        new JdeField("JLMAIL", "JLMAIL", JdeDataType.String, 20),
        new JdeField("JLSG", "JLSG", JdeDataType.String, 24),
        new JdeField("JLUN", "JLUN", JdeDataType.String, 12),
        new JdeField("JLJBCD", "JLJBCD", JdeDataType.String, 12),
        new JdeField("JLJBST", "JLJBST", JdeDataType.String, 8),
        new JdeField("JLP001", "JLP001", JdeDataType.String, 6),
        new JdeField("JLP002", "JLP002", JdeDataType.String, 6),
        new JdeField("JLP003", "JLP003", JdeDataType.String, 6),
        new JdeField("JLP004", "JLP004", JdeDataType.String, 6),
        new JdeField("JLICC", "JLICC", JdeDataType.String, 2),
        new JdeField("JLICS", "JLICS", JdeDataType.String, 2),
        new JdeField("JLGLBA", "JLGLBA", JdeDataType.String, 16),
        new JdeField("JLDOCM", "JLDOCM", JdeDataType.Numeric),
        new JdeField("JLCKDT", "JLCKDT", JdeDataType.Numeric),
        new JdeField("JLPPED", "JLPPED", JdeDataType.Numeric),
        new JdeField("JLPDBA", "JLPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JLDISO", "JLDISO", JdeDataType.String, 2),
        new JdeField("JLPCK", "JLPCK", JdeDataType.String, 2),
        new JdeField("JLPTCT", "JLPTCT", JdeDataType.String, 2),
        new JdeField("JLPAYG", "JLPAYG", JdeDataType.String, 2),
        new JdeField("JLPAYN", "JLPAYN", JdeDataType.String, 2),
        new JdeField("JLTARA", "JLTARA", JdeDataType.String, 20, true, true),
        new JdeField("JLPTAX", "JLPTAX", JdeDataType.String, 4, true, true),
        new JdeField("JLCE", "JLCE", JdeDataType.String, 2),
        new JdeField("JLNPAY", "JLNPAY", JdeDataType.Numeric),
        new JdeField("JLNPY1", "JLNPY1", JdeDataType.Numeric),
        new JdeField("JLIFO#", "JLIFO#", JdeDataType.String, 18),
        new JdeField("JLFOA#", "JLFOA#", JdeDataType.String, 34),
        new JdeField("JLNPY2", "JLNPY2", JdeDataType.Numeric),
        new JdeField("JLHRW", "JLHRW", JdeDataType.Numeric),
        new JdeField("JLHYTD", "JLHYTD", JdeDataType.Numeric),
        new JdeField("JLUNPC", "JLUNPC", JdeDataType.Numeric),
        new JdeField("JLBIPY", "JLBIPY", JdeDataType.Numeric),
        new JdeField("JLPHRT", "JLPHRT", JdeDataType.Numeric),
        new JdeField("JLBHRT", "JLBHRT", JdeDataType.Numeric),
        new JdeField("JLSHRT", "JLSHRT", JdeDataType.Numeric),
        new JdeField("JLPPRT", "JLPPRT", JdeDataType.Numeric),
        new JdeField("JLGPAY", "JLGPAY", JdeDataType.Numeric),
        new JdeField("JLG101", "JLG101", JdeDataType.Numeric),
        new JdeField("JLYTDG", "JLYTDG", JdeDataType.Numeric),
        new JdeField("JLG201", "JLG201", JdeDataType.Numeric),
        new JdeField("JLYTDE", "JLYTDE", JdeDataType.Numeric),
        new JdeField("JLG401", "JLG401", JdeDataType.Numeric),
        new JdeField("JLYTIE", "JLYTIE", JdeDataType.Numeric),
        new JdeField("JLG301", "JLG301", JdeDataType.Numeric),
        new JdeField("JLYTDT", "JLYTDT", JdeDataType.Numeric),
        new JdeField("JLRCND", "JLRCND", JdeDataType.String, 2),
        new JdeField("JLCLDT", "JLCLDT", JdeDataType.Numeric),
        new JdeField("JLDOCS", "JLDOCS", JdeDataType.Numeric),
        new JdeField("JLDOCP", "JLDOCP", JdeDataType.Numeric),
        new JdeField("JLREDT", "JLREDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06345_0", "Primary Key on JLAN8, JLRC, JLCKCN, JLPDBA, JLTARA, JLPTAX", new[] { "JLAN8", "JLRC", "JLCKCN", "JLPDBA", "JLTARA", "JLPTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06345_2", "Index on JLHMCO, JLAN8, JLCKDT, JLPDBA, JLTARA, JLPTAX", new[] { "JLHMCO", "JLAN8", "JLCKDT", "JLPDBA", "JLTARA", "JLPTAX" })
    };
}
