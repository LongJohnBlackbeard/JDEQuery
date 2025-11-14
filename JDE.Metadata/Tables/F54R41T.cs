using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54R41T - .
/// </summary>
public class F54R41T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIITM.
        /// </summary>
        public const string RIITM = "RIITM";

        /// <summary>
        /// RILITM.
        /// </summary>
        public const string RILITM = "RILITM";

        /// <summary>
        /// RIAITM.
        /// </summary>
        public const string RIAITM = "RIAITM";

        /// <summary>
        /// RIMCU.
        /// </summary>
        public const string RIMCU = "RIMCU";

        /// <summary>
        /// RILOCN.
        /// </summary>
        public const string RILOCN = "RILOCN";

        /// <summary>
        /// RILOTN.
        /// </summary>
        public const string RILOTN = "RILOTN";

        /// <summary>
        /// RI54RRF.
        /// </summary>
        public const string RI54RRF = "RI54RRF";

        /// <summary>
        /// RI54RRSD.
        /// </summary>
        public const string RI54RRSD = "RI54RRSD";

        /// <summary>
        /// RI54RRRD.
        /// </summary>
        public const string RI54RRRD = "RI54RRRD";

        /// <summary>
        /// RI54RAF.
        /// </summary>
        public const string RI54RAF = "RI54RAF";

        /// <summary>
        /// RI54RRIS.
        /// </summary>
        public const string RI54RRIS = "RI54RRIS";

        /// <summary>
        /// RI54RIBUM.
        /// </summary>
        public const string RI54RIBUM = "RI54RIBUM";

        /// <summary>
        /// RI54RADT.
        /// </summary>
        public const string RI54RADT = "RI54RADT";

        /// <summary>
        /// RI54RADD.
        /// </summary>
        public const string RI54RADD = "RI54RADD";

        /// <summary>
        /// RI54RADC.
        /// </summary>
        public const string RI54RADC = "RI54RADC";

        /// <summary>
        /// RI54RCC1.
        /// </summary>
        public const string RI54RCC1 = "RI54RCC1";

        /// <summary>
        /// RI54RCC2.
        /// </summary>
        public const string RI54RCC2 = "RI54RCC2";

        /// <summary>
        /// RI54RCC3.
        /// </summary>
        public const string RI54RCC3 = "RI54RCC3";

        /// <summary>
        /// RI54RCC4.
        /// </summary>
        public const string RI54RCC4 = "RI54RCC4";

        /// <summary>
        /// RI54RCC5.
        /// </summary>
        public const string RI54RCC5 = "RI54RCC5";

        /// <summary>
        /// RI54RCC6.
        /// </summary>
        public const string RI54RCC6 = "RI54RCC6";

        /// <summary>
        /// RI54RCC7.
        /// </summary>
        public const string RI54RCC7 = "RI54RCC7";

        /// <summary>
        /// RI54RCC8.
        /// </summary>
        public const string RI54RCC8 = "RI54RCC8";

        /// <summary>
        /// RI54RCC9.
        /// </summary>
        public const string RI54RCC9 = "RI54RCC9";

        /// <summary>
        /// RI54RCC10.
        /// </summary>
        public const string RI54RCC10 = "RI54RCC10";

        /// <summary>
        /// RI54RUD1.
        /// </summary>
        public const string RI54RUD1 = "RI54RUD1";

        /// <summary>
        /// RI54RUD2.
        /// </summary>
        public const string RI54RUD2 = "RI54RUD2";

        /// <summary>
        /// RI54RUD3.
        /// </summary>
        public const string RI54RUD3 = "RI54RUD3";

        /// <summary>
        /// RI54RUD4.
        /// </summary>
        public const string RI54RUD4 = "RI54RUD4";

        /// <summary>
        /// RI54RUD5.
        /// </summary>
        public const string RI54RUD5 = "RI54RUD5";

        /// <summary>
        /// RI54RCH1.
        /// </summary>
        public const string RI54RCH1 = "RI54RCH1";

        /// <summary>
        /// RI54RCH2.
        /// </summary>
        public const string RI54RCH2 = "RI54RCH2";

        /// <summary>
        /// RI54RCH3.
        /// </summary>
        public const string RI54RCH3 = "RI54RCH3";

        /// <summary>
        /// RI54RCH4.
        /// </summary>
        public const string RI54RCH4 = "RI54RCH4";

        /// <summary>
        /// RI54RCH5.
        /// </summary>
        public const string RI54RCH5 = "RI54RCH5";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RIUPMT.
        /// </summary>
        public const string RIUPMT = "RIUPMT";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIMKEY.
        /// </summary>
        public const string RIMKEY = "RIMKEY";

        /// <summary>
        /// RICRTU.
        /// </summary>
        public const string RICRTU = "RICRTU";

        /// <summary>
        /// RIENTJ.
        /// </summary>
        public const string RIENTJ = "RIENTJ";

        /// <summary>
        /// RITENT.
        /// </summary>
        public const string RITENT = "RITENT";

        /// <summary>
        /// RIURCD.
        /// </summary>
        public const string RIURCD = "RIURCD";

        /// <summary>
        /// RIURDT.
        /// </summary>
        public const string RIURDT = "RIURDT";

        /// <summary>
        /// RIURAT.
        /// </summary>
        public const string RIURAT = "RIURAT";

        /// <summary>
        /// RIURAB.
        /// </summary>
        public const string RIURAB = "RIURAB";

        /// <summary>
        /// RIURRF.
        /// </summary>
        public const string RIURRF = "RIURRF";

        /// <summary>
        /// RI54RIREF1.
        /// </summary>
        public const string RI54RIREF1 = "RI54RIREF1";

        /// <summary>
        /// RI54RIREF2.
        /// </summary>
        public const string RI54RIREF2 = "RI54RIREF2";

        /// <summary>
        /// RI54RIREF3.
        /// </summary>
        public const string RI54RIREF3 = "RI54RIREF3";

        /// <summary>
        /// RI54RIREF4.
        /// </summary>
        public const string RI54RIREF4 = "RI54RIREF4";

        /// <summary>
        /// RI54RIREF5.
        /// </summary>
        public const string RI54RIREF5 = "RI54RIREF5";
    }

    /// <inheritdoc />
    public override string TableName => "F54R41T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIITM", "RIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RILITM", "RILITM", JdeDataType.String, 50),
        new JdeField("RIAITM", "RIAITM", JdeDataType.String, 50),
        new JdeField("RIMCU", "RIMCU", JdeDataType.String, 24, true, true),
        new JdeField("RILOCN", "RILOCN", JdeDataType.String, 40, true, true),
        new JdeField("RILOTN", "RILOTN", JdeDataType.String, 60, true, true),
        new JdeField("RI54RRF", "RI54RRF", JdeDataType.String, 2),
        new JdeField("RI54RRSD", "RI54RRSD", JdeDataType.Numeric),
        new JdeField("RI54RRRD", "RI54RRRD", JdeDataType.Numeric),
        new JdeField("RI54RAF", "RI54RAF", JdeDataType.String, 2),
        new JdeField("RI54RRIS", "RI54RRIS", JdeDataType.String, 4),
        new JdeField("RI54RIBUM", "RI54RIBUM", JdeDataType.String, 4),
        new JdeField("RI54RADT", "RI54RADT", JdeDataType.String, 6),
        new JdeField("RI54RADD", "RI54RADD", JdeDataType.Numeric),
        new JdeField("RI54RADC", "RI54RADC", JdeDataType.String, 60),
        new JdeField("RI54RCC1", "RI54RCC1", JdeDataType.String, 6),
        new JdeField("RI54RCC2", "RI54RCC2", JdeDataType.String, 6),
        new JdeField("RI54RCC3", "RI54RCC3", JdeDataType.String, 6),
        new JdeField("RI54RCC4", "RI54RCC4", JdeDataType.String, 6),
        new JdeField("RI54RCC5", "RI54RCC5", JdeDataType.String, 6),
        new JdeField("RI54RCC6", "RI54RCC6", JdeDataType.String, 6),
        new JdeField("RI54RCC7", "RI54RCC7", JdeDataType.String, 6),
        new JdeField("RI54RCC8", "RI54RCC8", JdeDataType.String, 6),
        new JdeField("RI54RCC9", "RI54RCC9", JdeDataType.String, 6),
        new JdeField("RI54RCC10", "RI54RCC10", JdeDataType.String, 6),
        new JdeField("RI54RUD1", "RI54RUD1", JdeDataType.Numeric),
        new JdeField("RI54RUD2", "RI54RUD2", JdeDataType.Numeric),
        new JdeField("RI54RUD3", "RI54RUD3", JdeDataType.Numeric),
        new JdeField("RI54RUD4", "RI54RUD4", JdeDataType.Numeric),
        new JdeField("RI54RUD5", "RI54RUD5", JdeDataType.Numeric),
        new JdeField("RI54RCH1", "RI54RCH1", JdeDataType.String, 2),
        new JdeField("RI54RCH2", "RI54RCH2", JdeDataType.String, 2),
        new JdeField("RI54RCH3", "RI54RCH3", JdeDataType.String, 2),
        new JdeField("RI54RCH4", "RI54RCH4", JdeDataType.String, 2),
        new JdeField("RI54RCH5", "RI54RCH5", JdeDataType.String, 2),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RIUPMT", "RIUPMT", JdeDataType.Numeric),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIMKEY", "RIMKEY", JdeDataType.String, 30),
        new JdeField("RICRTU", "RICRTU", JdeDataType.String, 20),
        new JdeField("RIENTJ", "RIENTJ", JdeDataType.Numeric),
        new JdeField("RITENT", "RITENT", JdeDataType.Numeric),
        new JdeField("RIURCD", "RIURCD", JdeDataType.String, 4),
        new JdeField("RIURDT", "RIURDT", JdeDataType.Numeric),
        new JdeField("RIURAT", "RIURAT", JdeDataType.Numeric),
        new JdeField("RIURAB", "RIURAB", JdeDataType.Numeric),
        new JdeField("RIURRF", "RIURRF", JdeDataType.String, 30),
        new JdeField("RI54RIREF1", "RI54RIREF1", JdeDataType.String, 70),
        new JdeField("RI54RIREF2", "RI54RIREF2", JdeDataType.String, 70),
        new JdeField("RI54RIREF3", "RI54RIREF3", JdeDataType.String, 70),
        new JdeField("RI54RIREF4", "RI54RIREF4", JdeDataType.String, 70),
        new JdeField("RI54RIREF5", "RI54RIREF5", JdeDataType.String, 70)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54R41T_0", "Primary Key on RIITM, RIMCU, RILOCN, RILOTN", new[] { "RIITM", "RIMCU", "RILOCN", "RILOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F54R41T_2", "Index on RIITM, RIMCU, RILOCN", new[] { "RIITM", "RIMCU", "RILOCN" })
    };
}
