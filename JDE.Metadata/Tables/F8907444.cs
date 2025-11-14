using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8907444 - .
/// </summary>
public class F8907444 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TXMATH01.
        /// </summary>
        public const string TXMATH01 = "TXMATH01";

        /// <summary>
        /// TXDL01.
        /// </summary>
        public const string TXDL01 = "TXDL01";

        /// <summary>
        /// TXMATH02.
        /// </summary>
        public const string TXMATH02 = "TXMATH02";

        /// <summary>
        /// TXSSN.
        /// </summary>
        public const string TXSSN = "TXSSN";

        /// <summary>
        /// TXGNNM.
        /// </summary>
        public const string TXGNNM = "TXGNNM";

        /// <summary>
        /// TXMDNM.
        /// </summary>
        public const string TXMDNM = "TXMDNM";

        /// <summary>
        /// TXSRNM.
        /// </summary>
        public const string TXSRNM = "TXSRNM";

        /// <summary>
        /// TXADD1.
        /// </summary>
        public const string TXADD1 = "TXADD1";

        /// <summary>
        /// TXADD2.
        /// </summary>
        public const string TXADD2 = "TXADD2";

        /// <summary>
        /// TXADD3.
        /// </summary>
        public const string TXADD3 = "TXADD3";

        /// <summary>
        /// TXCTY1.
        /// </summary>
        public const string TXCTY1 = "TXCTY1";

        /// <summary>
        /// TXADDS.
        /// </summary>
        public const string TXADDS = "TXADDS";

        /// <summary>
        /// TXADDZ.
        /// </summary>
        public const string TXADDZ = "TXADDZ";

        /// <summary>
        /// TXCRTE.
        /// </summary>
        public const string TXCRTE = "TXCRTE";

        /// <summary>
        /// TXCTR.
        /// </summary>
        public const string TXCTR = "TXCTR";

        /// <summary>
        /// TXDL02.
        /// </summary>
        public const string TXDL02 = "TXDL02";

        /// <summary>
        /// TXFPC1.
        /// </summary>
        public const string TXFPC1 = "TXFPC1";

        /// <summary>
        /// TXDL03.
        /// </summary>
        public const string TXDL03 = "TXDL03";

        /// <summary>
        /// TXDL04.
        /// </summary>
        public const string TXDL04 = "TXDL04";

        /// <summary>
        /// TXADDSNH2.
        /// </summary>
        public const string TXADDSNH2 = "TXADDSNH2";

        /// <summary>
        /// TXTAXX.
        /// </summary>
        public const string TXTAXX = "TXTAXX";

        /// <summary>
        /// TXETAX.
        /// </summary>
        public const string TXETAX = "TXETAX";

        /// <summary>
        /// TXALPH1.
        /// </summary>
        public const string TXALPH1 = "TXALPH1";

        /// <summary>
        /// TXADD4.
        /// </summary>
        public const string TXADD4 = "TXADD4";

        /// <summary>
        /// TXADD5.
        /// </summary>
        public const string TXADD5 = "TXADD5";

        /// <summary>
        /// TXADD6.
        /// </summary>
        public const string TXADD6 = "TXADD6";

        /// <summary>
        /// TXMSCY.
        /// </summary>
        public const string TXMSCY = "TXMSCY";

        /// <summary>
        /// TXSTCD.
        /// </summary>
        public const string TXSTCD = "TXSTCD";

        /// <summary>
        /// TXADDO.
        /// </summary>
        public const string TXADDO = "TXADDO";

        /// <summary>
        /// TXCRRT.
        /// </summary>
        public const string TXCRRT = "TXCRRT";

        /// <summary>
        /// TXCTR2.
        /// </summary>
        public const string TXCTR2 = "TXCTR2";

        /// <summary>
        /// TXDL05.
        /// </summary>
        public const string TXDL05 = "TXDL05";

        /// <summary>
        /// TXFPC2.
        /// </summary>
        public const string TXFPC2 = "TXFPC2";

        /// <summary>
        /// TXADD7.
        /// </summary>
        public const string TXADD7 = "TXADD7";

        /// <summary>
        /// TXADD8.
        /// </summary>
        public const string TXADD8 = "TXADD8";

        /// <summary>
        /// TXADD9.
        /// </summary>
        public const string TXADD9 = "TXADD9";

        /// <summary>
        /// TXCTYNH.
        /// </summary>
        public const string TXCTYNH = "TXCTYNH";

        /// <summary>
        /// TXADDSNH.
        /// </summary>
        public const string TXADDSNH = "TXADDSNH";

        /// <summary>
        /// TXADDZNH.
        /// </summary>
        public const string TXADDZNH = "TXADDZNH";

        /// <summary>
        /// TXCRTENH.
        /// </summary>
        public const string TXCRTENH = "TXCRTENH";

        /// <summary>
        /// TXCTR4.
        /// </summary>
        public const string TXCTR4 = "TXCTR4";

        /// <summary>
        /// TXDL06.
        /// </summary>
        public const string TXDL06 = "TXDL06";

        /// <summary>
        /// TXFPC3.
        /// </summary>
        public const string TXFPC3 = "TXFPC3";

        /// <summary>
        /// TXSAL.
        /// </summary>
        public const string TXSAL = "TXSAL";

        /// <summary>
        /// TXPFRQ.
        /// </summary>
        public const string TXPFRQ = "TXPFRQ";
    }

    /// <inheritdoc />
    public override string TableName => "F8907444";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TXMATH01", "TXMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("TXDL01", "TXDL01", JdeDataType.String, 60),
        new JdeField("TXMATH02", "TXMATH02", JdeDataType.Numeric),
        new JdeField("TXSSN", "TXSSN", JdeDataType.String, 40),
        new JdeField("TXGNNM", "TXGNNM", JdeDataType.String, 50),
        new JdeField("TXMDNM", "TXMDNM", JdeDataType.String, 50),
        new JdeField("TXSRNM", "TXSRNM", JdeDataType.String, 50),
        new JdeField("TXADD1", "TXADD1", JdeDataType.String, 80),
        new JdeField("TXADD2", "TXADD2", JdeDataType.String, 80),
        new JdeField("TXADD3", "TXADD3", JdeDataType.String, 80),
        new JdeField("TXCTY1", "TXCTY1", JdeDataType.String, 50),
        new JdeField("TXADDS", "TXADDS", JdeDataType.String, 6),
        new JdeField("TXADDZ", "TXADDZ", JdeDataType.String, 24),
        new JdeField("TXCRTE", "TXCRTE", JdeDataType.String, 8),
        new JdeField("TXCTR", "TXCTR", JdeDataType.String, 6),
        new JdeField("TXDL02", "TXDL02", JdeDataType.String, 60),
        new JdeField("TXFPC1", "TXFPC1", JdeDataType.String, 30),
        new JdeField("TXDL03", "TXDL03", JdeDataType.String, 60),
        new JdeField("TXDL04", "TXDL04", JdeDataType.String, 60),
        new JdeField("TXADDSNH2", "TXADDSNH2", JdeDataType.String, 6),
        new JdeField("TXTAXX", "TXTAXX", JdeDataType.String, 40),
        new JdeField("TXETAX", "TXETAX", JdeDataType.String, 40),
        new JdeField("TXALPH1", "TXALPH1", JdeDataType.String, 80),
        new JdeField("TXADD4", "TXADD4", JdeDataType.String, 80),
        new JdeField("TXADD5", "TXADD5", JdeDataType.String, 80),
        new JdeField("TXADD6", "TXADD6", JdeDataType.String, 80),
        new JdeField("TXMSCY", "TXMSCY", JdeDataType.String, 50),
        new JdeField("TXSTCD", "TXSTCD", JdeDataType.String, 6),
        new JdeField("TXADDO", "TXADDO", JdeDataType.String, 24),
        new JdeField("TXCRRT", "TXCRRT", JdeDataType.String, 8),
        new JdeField("TXCTR2", "TXCTR2", JdeDataType.String, 6),
        new JdeField("TXDL05", "TXDL05", JdeDataType.String, 60),
        new JdeField("TXFPC2", "TXFPC2", JdeDataType.String, 30),
        new JdeField("TXADD7", "TXADD7", JdeDataType.String, 80),
        new JdeField("TXADD8", "TXADD8", JdeDataType.String, 80),
        new JdeField("TXADD9", "TXADD9", JdeDataType.String, 80),
        new JdeField("TXCTYNH", "TXCTYNH", JdeDataType.String, 50),
        new JdeField("TXADDSNH", "TXADDSNH", JdeDataType.String, 6),
        new JdeField("TXADDZNH", "TXADDZNH", JdeDataType.String, 24),
        new JdeField("TXCRTENH", "TXCRTENH", JdeDataType.String, 8),
        new JdeField("TXCTR4", "TXCTR4", JdeDataType.String, 6),
        new JdeField("TXDL06", "TXDL06", JdeDataType.String, 60),
        new JdeField("TXFPC3", "TXFPC3", JdeDataType.String, 30),
        new JdeField("TXSAL", "TXSAL", JdeDataType.Numeric),
        new JdeField("TXPFRQ", "TXPFRQ", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8907444_0", "Primary Key on TXMATH01", new[] { "TXMATH01" }, isUnique: true, isPrimaryKey: true)
    };
}
