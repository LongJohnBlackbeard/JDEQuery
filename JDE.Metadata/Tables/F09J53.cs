using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J53 - .
/// </summary>
public class F09J53 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIJVAGN.
        /// </summary>
        public const string OIJVAGN = "OIJVAGN";

        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OIJVINEX.
        /// </summary>
        public const string OIJVINEX = "OIJVINEX";

        /// <summary>
        /// OIBEGOBJ.
        /// </summary>
        public const string OIBEGOBJ = "OIBEGOBJ";

        /// <summary>
        /// OIENDOBJ.
        /// </summary>
        public const string OIENDOBJ = "OIENDOBJ";

        /// <summary>
        /// OIBEGSUB.
        /// </summary>
        public const string OIBEGSUB = "OIBEGSUB";

        /// <summary>
        /// OIJVAGD.
        /// </summary>
        public const string OIJVAGD = "OIJVAGD";

        /// <summary>
        /// OIJVRMK.
        /// </summary>
        public const string OIJVRMK = "OIJVRMK";

        /// <summary>
        /// OITORG.
        /// </summary>
        public const string OITORG = "OITORG";

        /// <summary>
        /// OIENTJ.
        /// </summary>
        public const string OIENTJ = "OIENTJ";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OIUPMT.
        /// </summary>
        public const string OIUPMT = "OIUPMT";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIMKEY.
        /// </summary>
        public const string OIMKEY = "OIMKEY";

        /// <summary>
        /// OIJVFNU1.
        /// </summary>
        public const string OIJVFNU1 = "OIJVFNU1";

        /// <summary>
        /// OIJVFNU2.
        /// </summary>
        public const string OIJVFNU2 = "OIJVFNU2";

        /// <summary>
        /// OIJVFNU3.
        /// </summary>
        public const string OIJVFNU3 = "OIJVFNU3";

        /// <summary>
        /// OIJVFST1.
        /// </summary>
        public const string OIJVFST1 = "OIJVFST1";

        /// <summary>
        /// OIJVFST2.
        /// </summary>
        public const string OIJVFST2 = "OIJVFST2";

        /// <summary>
        /// OIJVFST3.
        /// </summary>
        public const string OIJVFST3 = "OIJVFST3";

        /// <summary>
        /// OIENDSUB.
        /// </summary>
        public const string OIENDSUB = "OIENDSUB";

        /// <summary>
        /// OIJVFCH1.
        /// </summary>
        public const string OIJVFCH1 = "OIJVFCH1";

        /// <summary>
        /// OIJVFCH2.
        /// </summary>
        public const string OIJVFCH2 = "OIJVFCH2";

        /// <summary>
        /// OIJVFCH3.
        /// </summary>
        public const string OIJVFCH3 = "OIJVFCH3";

        /// <summary>
        /// OIJVFDT1.
        /// </summary>
        public const string OIJVFDT1 = "OIJVFDT1";

        /// <summary>
        /// OIJVFDT2.
        /// </summary>
        public const string OIJVFDT2 = "OIJVFDT2";

        /// <summary>
        /// OIJVFDT3.
        /// </summary>
        public const string OIJVFDT3 = "OIJVFDT3";

        /// <summary>
        /// OIURCDAG01.
        /// </summary>
        public const string OIURCDAG01 = "OIURCDAG01";

        /// <summary>
        /// OIURCDAG02.
        /// </summary>
        public const string OIURCDAG02 = "OIURCDAG02";

        /// <summary>
        /// OIURCDAG03.
        /// </summary>
        public const string OIURCDAG03 = "OIURCDAG03";

        /// <summary>
        /// OIURCDAG04.
        /// </summary>
        public const string OIURCDAG04 = "OIURCDAG04";

        /// <summary>
        /// OIURCDAG05.
        /// </summary>
        public const string OIURCDAG05 = "OIURCDAG05";

        /// <summary>
        /// OIURDTAG01.
        /// </summary>
        public const string OIURDTAG01 = "OIURDTAG01";

        /// <summary>
        /// OIURDTAG02.
        /// </summary>
        public const string OIURDTAG02 = "OIURDTAG02";

        /// <summary>
        /// OIURDTAG03.
        /// </summary>
        public const string OIURDTAG03 = "OIURDTAG03";

        /// <summary>
        /// OIURDTAG04.
        /// </summary>
        public const string OIURDTAG04 = "OIURDTAG04";

        /// <summary>
        /// OIURDTAG05.
        /// </summary>
        public const string OIURDTAG05 = "OIURDTAG05";

        /// <summary>
        /// OIURRFAG01.
        /// </summary>
        public const string OIURRFAG01 = "OIURRFAG01";

        /// <summary>
        /// OIURRFAG02.
        /// </summary>
        public const string OIURRFAG02 = "OIURRFAG02";

        /// <summary>
        /// OIURRFAG03.
        /// </summary>
        public const string OIURRFAG03 = "OIURRFAG03";

        /// <summary>
        /// OIURRFAG04.
        /// </summary>
        public const string OIURRFAG04 = "OIURRFAG04";

        /// <summary>
        /// OIURRFAG05.
        /// </summary>
        public const string OIURRFAG05 = "OIURRFAG05";

        /// <summary>
        /// OIURATAG01.
        /// </summary>
        public const string OIURATAG01 = "OIURATAG01";

        /// <summary>
        /// OIURATAG02.
        /// </summary>
        public const string OIURATAG02 = "OIURATAG02";

        /// <summary>
        /// OIURATAG03.
        /// </summary>
        public const string OIURATAG03 = "OIURATAG03";

        /// <summary>
        /// OIURATAG04.
        /// </summary>
        public const string OIURATAG04 = "OIURATAG04";

        /// <summary>
        /// OIURATAG05.
        /// </summary>
        public const string OIURATAG05 = "OIURATAG05";

        /// <summary>
        /// OIURNMAG01.
        /// </summary>
        public const string OIURNMAG01 = "OIURNMAG01";

        /// <summary>
        /// OIURNMAG02.
        /// </summary>
        public const string OIURNMAG02 = "OIURNMAG02";

        /// <summary>
        /// OIURNMAG03.
        /// </summary>
        public const string OIURNMAG03 = "OIURNMAG03";

        /// <summary>
        /// OIURNMAG04.
        /// </summary>
        public const string OIURNMAG04 = "OIURNMAG04";

        /// <summary>
        /// OIURNMAG05.
        /// </summary>
        public const string OIURNMAG05 = "OIURNMAG05";

        /// <summary>
        /// OIURSTAG01.
        /// </summary>
        public const string OIURSTAG01 = "OIURSTAG01";

        /// <summary>
        /// OIURSTAG02.
        /// </summary>
        public const string OIURSTAG02 = "OIURSTAG02";

        /// <summary>
        /// OIURSTAG03.
        /// </summary>
        public const string OIURSTAG03 = "OIURSTAG03";

        /// <summary>
        /// OIURSTAG04.
        /// </summary>
        public const string OIURSTAG04 = "OIURSTAG04";

        /// <summary>
        /// OIURSTAG05.
        /// </summary>
        public const string OIURSTAG05 = "OIURSTAG05";
    }

    /// <inheritdoc />
    public override string TableName => "F09J53";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIJVAGN", "OIJVAGN", JdeDataType.String, 40, true, true),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24, true, true),
        new JdeField("OIJVINEX", "OIJVINEX", JdeDataType.String, 2, true, true),
        new JdeField("OIBEGOBJ", "OIBEGOBJ", JdeDataType.String, 12, true, true),
        new JdeField("OIENDOBJ", "OIENDOBJ", JdeDataType.String, 12),
        new JdeField("OIBEGSUB", "OIBEGSUB", JdeDataType.String, 16, true, true),
        new JdeField("OIJVAGD", "OIJVAGD", JdeDataType.String, 160),
        new JdeField("OIJVRMK", "OIJVRMK", JdeDataType.String, 160),
        new JdeField("OITORG", "OITORG", JdeDataType.String, 20),
        new JdeField("OIENTJ", "OIENTJ", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OIUPMT", "OIUPMT", JdeDataType.Numeric),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIMKEY", "OIMKEY", JdeDataType.String, 30),
        new JdeField("OIJVFNU1", "OIJVFNU1", JdeDataType.Numeric),
        new JdeField("OIJVFNU2", "OIJVFNU2", JdeDataType.Numeric),
        new JdeField("OIJVFNU3", "OIJVFNU3", JdeDataType.Numeric),
        new JdeField("OIJVFST1", "OIJVFST1", JdeDataType.String, 160),
        new JdeField("OIJVFST2", "OIJVFST2", JdeDataType.String, 160),
        new JdeField("OIJVFST3", "OIJVFST3", JdeDataType.String, 160),
        new JdeField("OIENDSUB", "OIENDSUB", JdeDataType.String, 16),
        new JdeField("OIJVFCH1", "OIJVFCH1", JdeDataType.String, 2),
        new JdeField("OIJVFCH2", "OIJVFCH2", JdeDataType.String, 2),
        new JdeField("OIJVFCH3", "OIJVFCH3", JdeDataType.String, 2),
        new JdeField("OIJVFDT1", "OIJVFDT1", JdeDataType.Numeric),
        new JdeField("OIJVFDT2", "OIJVFDT2", JdeDataType.Numeric),
        new JdeField("OIJVFDT3", "OIJVFDT3", JdeDataType.Numeric),
        new JdeField("OIURCDAG01", "OIURCDAG01", JdeDataType.String, 4),
        new JdeField("OIURCDAG02", "OIURCDAG02", JdeDataType.String, 4),
        new JdeField("OIURCDAG03", "OIURCDAG03", JdeDataType.String, 4),
        new JdeField("OIURCDAG04", "OIURCDAG04", JdeDataType.String, 4),
        new JdeField("OIURCDAG05", "OIURCDAG05", JdeDataType.String, 4),
        new JdeField("OIURDTAG01", "OIURDTAG01", JdeDataType.Numeric),
        new JdeField("OIURDTAG02", "OIURDTAG02", JdeDataType.Numeric),
        new JdeField("OIURDTAG03", "OIURDTAG03", JdeDataType.Numeric),
        new JdeField("OIURDTAG04", "OIURDTAG04", JdeDataType.Numeric),
        new JdeField("OIURDTAG05", "OIURDTAG05", JdeDataType.Numeric),
        new JdeField("OIURRFAG01", "OIURRFAG01", JdeDataType.String, 30),
        new JdeField("OIURRFAG02", "OIURRFAG02", JdeDataType.String, 30),
        new JdeField("OIURRFAG03", "OIURRFAG03", JdeDataType.String, 30),
        new JdeField("OIURRFAG04", "OIURRFAG04", JdeDataType.String, 30),
        new JdeField("OIURRFAG05", "OIURRFAG05", JdeDataType.String, 30),
        new JdeField("OIURATAG01", "OIURATAG01", JdeDataType.Numeric),
        new JdeField("OIURATAG02", "OIURATAG02", JdeDataType.Numeric),
        new JdeField("OIURATAG03", "OIURATAG03", JdeDataType.Numeric),
        new JdeField("OIURATAG04", "OIURATAG04", JdeDataType.Numeric),
        new JdeField("OIURATAG05", "OIURATAG05", JdeDataType.Numeric),
        new JdeField("OIURNMAG01", "OIURNMAG01", JdeDataType.Numeric),
        new JdeField("OIURNMAG02", "OIURNMAG02", JdeDataType.Numeric),
        new JdeField("OIURNMAG03", "OIURNMAG03", JdeDataType.Numeric),
        new JdeField("OIURNMAG04", "OIURNMAG04", JdeDataType.Numeric),
        new JdeField("OIURNMAG05", "OIURNMAG05", JdeDataType.Numeric),
        new JdeField("OIURSTAG01", "OIURSTAG01", JdeDataType.String, 160),
        new JdeField("OIURSTAG02", "OIURSTAG02", JdeDataType.String, 160),
        new JdeField("OIURSTAG03", "OIURSTAG03", JdeDataType.String, 160),
        new JdeField("OIURSTAG04", "OIURSTAG04", JdeDataType.String, 160),
        new JdeField("OIURSTAG05", "OIURSTAG05", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J53_0", "Primary Key on OIJVAGN, OIMCU, OIJVINEX, OIBEGOBJ, OIBEGSUB", new[] { "OIJVAGN", "OIMCU", "OIJVINEX", "OIBEGOBJ", "OIBEGSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J53_2", "Index on OIJVAGN", new[] { "OIJVAGN" }),
        new JdeIndex("F09J53_3", "Index on OIJVAGN, SYS_NC00059$, SYS_NC00060$", new[] { "OIJVAGN", "SYS_NC00059$", "SYS_NC00060$" }),
        new JdeIndex("F09J53_4", "Index on OIJVAGN, OIJVAGD", new[] { "OIJVAGN", "OIJVAGD" })
    };
}
