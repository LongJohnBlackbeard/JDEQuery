using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41181 - .
/// </summary>
public class F41181 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMITM.
        /// </summary>
        public const string CMITM = "CMITM";

        /// <summary>
        /// CMITRF.
        /// </summary>
        public const string CMITRF = "CMITRF";

        /// <summary>
        /// CMMCU.
        /// </summary>
        public const string CMMCU = "CMMCU";

        /// <summary>
        /// CMCO.
        /// </summary>
        public const string CMCO = "CMCO";

        /// <summary>
        /// CMUM.
        /// </summary>
        public const string CMUM = "CMUM";

        /// <summary>
        /// CMSHAN.
        /// </summary>
        public const string CMSHAN = "CMSHAN";

        /// <summary>
        /// CMDOCO.
        /// </summary>
        public const string CMDOCO = "CMDOCO";

        /// <summary>
        /// CMDCTO.
        /// </summary>
        public const string CMDCTO = "CMDCTO";

        /// <summary>
        /// CMKCOO.
        /// </summary>
        public const string CMKCOO = "CMKCOO";

        /// <summary>
        /// CMLNID.
        /// </summary>
        public const string CMLNID = "CMLNID";

        /// <summary>
        /// CMLNTY.
        /// </summary>
        public const string CMLNTY = "CMLNTY";

        /// <summary>
        /// CMUORG.
        /// </summary>
        public const string CMUORG = "CMUORG";

        /// <summary>
        /// CMRNRT.
        /// </summary>
        public const string CMRNRT = "CMRNRT";

        /// <summary>
        /// CMTRDJ.
        /// </summary>
        public const string CMTRDJ = "CMTRDJ";

        /// <summary>
        /// CMRNCH.
        /// </summary>
        public const string CMRNCH = "CMRNCH";

        /// <summary>
        /// CMRNDT.
        /// </summary>
        public const string CMRNDT = "CMRNDT";

        /// <summary>
        /// CMSIDT.
        /// </summary>
        public const string CMSIDT = "CMSIDT";

        /// <summary>
        /// CMRKCO.
        /// </summary>
        public const string CMRKCO = "CMRKCO";

        /// <summary>
        /// CMRORN.
        /// </summary>
        public const string CMRORN = "CMRORN";

        /// <summary>
        /// CMRCTO.
        /// </summary>
        public const string CMRCTO = "CMRCTO";

        /// <summary>
        /// CMRLLN.
        /// </summary>
        public const string CMRLLN = "CMRLLN";

        /// <summary>
        /// CMCTDR.
        /// </summary>
        public const string CMCTDR = "CMCTDR";

        /// <summary>
        /// CMCTTS.
        /// </summary>
        public const string CMCTTS = "CMCTTS";

        /// <summary>
        /// CMGLC.
        /// </summary>
        public const string CMGLC = "CMGLC";

        /// <summary>
        /// CMCRCD.
        /// </summary>
        public const string CMCRCD = "CMCRCD";

        /// <summary>
        /// CMCRR.
        /// </summary>
        public const string CMCRR = "CMCRR";

        /// <summary>
        /// CMFRRT.
        /// </summary>
        public const string CMFRRT = "CMFRRT";

        /// <summary>
        /// CMFRAA.
        /// </summary>
        public const string CMFRAA = "CMFRAA";

        /// <summary>
        /// CMRCFL.
        /// </summary>
        public const string CMRCFL = "CMRCFL";

        /// <summary>
        /// CMPRFL.
        /// </summary>
        public const string CMPRFL = "CMPRFL";

        /// <summary>
        /// CMURAT.
        /// </summary>
        public const string CMURAT = "CMURAT";

        /// <summary>
        /// CMURCD.
        /// </summary>
        public const string CMURCD = "CMURCD";

        /// <summary>
        /// CMURC1.
        /// </summary>
        public const string CMURC1 = "CMURC1";

        /// <summary>
        /// CMURDT.
        /// </summary>
        public const string CMURDT = "CMURDT";

        /// <summary>
        /// CMURAB.
        /// </summary>
        public const string CMURAB = "CMURAB";

        /// <summary>
        /// CMURRF.
        /// </summary>
        public const string CMURRF = "CMURRF";

        /// <summary>
        /// CMCTQT.
        /// </summary>
        public const string CMCTQT = "CMCTQT";

        /// <summary>
        /// CMCMDT.
        /// </summary>
        public const string CMCMDT = "CMCMDT";

        /// <summary>
        /// CMCMUM.
        /// </summary>
        public const string CMCMUM = "CMCMUM";

        /// <summary>
        /// CMCTCD.
        /// </summary>
        public const string CMCTCD = "CMCTCD";

        /// <summary>
        /// CMCM01.
        /// </summary>
        public const string CMCM01 = "CMCM01";

        /// <summary>
        /// CMCM02.
        /// </summary>
        public const string CMCM02 = "CMCM02";

        /// <summary>
        /// CMCM03.
        /// </summary>
        public const string CMCM03 = "CMCM03";

        /// <summary>
        /// CMCM04.
        /// </summary>
        public const string CMCM04 = "CMCM04";

        /// <summary>
        /// CMCM05.
        /// </summary>
        public const string CMCM05 = "CMCM05";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMTDAY.
        /// </summary>
        public const string CMTDAY = "CMTDAY";

        /// <summary>
        /// CMUKID.
        /// </summary>
        public const string CMUKID = "CMUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F41181";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric),
        new JdeField("CMITM", "CMITM", JdeDataType.Numeric),
        new JdeField("CMITRF", "CMITRF", JdeDataType.Numeric),
        new JdeField("CMMCU", "CMMCU", JdeDataType.String, 24),
        new JdeField("CMCO", "CMCO", JdeDataType.String, 10),
        new JdeField("CMUM", "CMUM", JdeDataType.String, 4),
        new JdeField("CMSHAN", "CMSHAN", JdeDataType.Numeric),
        new JdeField("CMDOCO", "CMDOCO", JdeDataType.Numeric),
        new JdeField("CMDCTO", "CMDCTO", JdeDataType.String, 4),
        new JdeField("CMKCOO", "CMKCOO", JdeDataType.String, 10),
        new JdeField("CMLNID", "CMLNID", JdeDataType.Numeric),
        new JdeField("CMLNTY", "CMLNTY", JdeDataType.String, 4),
        new JdeField("CMUORG", "CMUORG", JdeDataType.Numeric),
        new JdeField("CMRNRT", "CMRNRT", JdeDataType.Numeric),
        new JdeField("CMTRDJ", "CMTRDJ", JdeDataType.Numeric),
        new JdeField("CMRNCH", "CMRNCH", JdeDataType.Numeric),
        new JdeField("CMRNDT", "CMRNDT", JdeDataType.Numeric),
        new JdeField("CMSIDT", "CMSIDT", JdeDataType.Numeric),
        new JdeField("CMRKCO", "CMRKCO", JdeDataType.String, 10),
        new JdeField("CMRORN", "CMRORN", JdeDataType.String, 16),
        new JdeField("CMRCTO", "CMRCTO", JdeDataType.String, 4),
        new JdeField("CMRLLN", "CMRLLN", JdeDataType.Numeric),
        new JdeField("CMCTDR", "CMCTDR", JdeDataType.String, 2),
        new JdeField("CMCTTS", "CMCTTS", JdeDataType.String, 2),
        new JdeField("CMGLC", "CMGLC", JdeDataType.String, 8),
        new JdeField("CMCRCD", "CMCRCD", JdeDataType.String, 6),
        new JdeField("CMCRR", "CMCRR", JdeDataType.Numeric),
        new JdeField("CMFRRT", "CMFRRT", JdeDataType.Numeric),
        new JdeField("CMFRAA", "CMFRAA", JdeDataType.Numeric),
        new JdeField("CMRCFL", "CMRCFL", JdeDataType.String, 2),
        new JdeField("CMPRFL", "CMPRFL", JdeDataType.String, 2),
        new JdeField("CMURAT", "CMURAT", JdeDataType.Numeric),
        new JdeField("CMURCD", "CMURCD", JdeDataType.String, 4),
        new JdeField("CMURC1", "CMURC1", JdeDataType.String, 6),
        new JdeField("CMURDT", "CMURDT", JdeDataType.Numeric),
        new JdeField("CMURAB", "CMURAB", JdeDataType.Numeric),
        new JdeField("CMURRF", "CMURRF", JdeDataType.String, 30),
        new JdeField("CMCTQT", "CMCTQT", JdeDataType.Numeric),
        new JdeField("CMCMDT", "CMCMDT", JdeDataType.Numeric),
        new JdeField("CMCMUM", "CMCMUM", JdeDataType.String, 4),
        new JdeField("CMCTCD", "CMCTCD", JdeDataType.String, 4),
        new JdeField("CMCM01", "CMCM01", JdeDataType.String, 2),
        new JdeField("CMCM02", "CMCM02", JdeDataType.String, 2),
        new JdeField("CMCM03", "CMCM03", JdeDataType.String, 2),
        new JdeField("CMCM04", "CMCM04", JdeDataType.String, 2),
        new JdeField("CMCM05", "CMCM05", JdeDataType.String, 2),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMTDAY", "CMTDAY", JdeDataType.Numeric),
        new JdeField("CMUKID", "CMUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41181_0", "Primary Key on CMUKID", new[] { "CMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41181_1", "Index on CMAN8, CMITM, CMDOCO, CMDCTO, CMKCOO, CMLNID", new[] { "CMAN8", "CMITM", "CMDOCO", "CMDCTO", "CMKCOO", "CMLNID" }),
        new JdeIndex("F41181_2", "Index on CMAN8, CMITM, CMLNTY, CMSIDT", new[] { "CMAN8", "CMITM", "CMLNTY", "CMSIDT" }),
        new JdeIndex("F41181_3", "Index on CMITM, CMMCU, CMRCFL", new[] { "CMITM", "CMMCU", "CMRCFL" }),
        new JdeIndex("F41181_4", "Index on CMAN8, CMITM", new[] { "CMAN8", "CMITM" }),
        new JdeIndex("F41181_5", "Index on CMAN8, CMRORN, CMRCTO, CMRKCO, CMRLLN, CMITM", new[] { "CMAN8", "CMRORN", "CMRCTO", "CMRKCO", "CMRLLN", "CMITM" }),
        new JdeIndex("F41181_6", "Index on CMAN8, CMITM, CMRORN, CMRCTO, CMRKCO, CMRLLN", new[] { "CMAN8", "CMITM", "CMRORN", "CMRCTO", "CMRKCO", "CMRLLN" })
    };
}
