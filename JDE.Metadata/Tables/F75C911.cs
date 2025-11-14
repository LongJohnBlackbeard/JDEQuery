using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C911 - .
/// </summary>
public class F75C911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DNCO.
        /// </summary>
        public const string DNCO = "DNCO";

        /// <summary>
        /// DNDGJ.
        /// </summary>
        public const string DNDGJ = "DNDGJ";

        /// <summary>
        /// DNICU.
        /// </summary>
        public const string DNICU = "DNICU";

        /// <summary>
        /// DNDOC.
        /// </summary>
        public const string DNDOC = "DNDOC";

        /// <summary>
        /// DNLT.
        /// </summary>
        public const string DNLT = "DNLT";

        /// <summary>
        /// DNC75CDOC.
        /// </summary>
        public const string DNC75CDOC = "DNC75CDOC";

        /// <summary>
        /// DNPID.
        /// </summary>
        public const string DNPID = "DNPID";

        /// <summary>
        /// DNJOBN.
        /// </summary>
        public const string DNJOBN = "DNJOBN";

        /// <summary>
        /// DNUSER.
        /// </summary>
        public const string DNUSER = "DNUSER";

        /// <summary>
        /// DNUPMT.
        /// </summary>
        public const string DNUPMT = "DNUPMT";

        /// <summary>
        /// DNUPMJ.
        /// </summary>
        public const string DNUPMJ = "DNUPMJ";

        /// <summary>
        /// DNFUT1.
        /// </summary>
        public const string DNFUT1 = "DNFUT1";

        /// <summary>
        /// DNFUT2.
        /// </summary>
        public const string DNFUT2 = "DNFUT2";

        /// <summary>
        /// DNFUT3.
        /// </summary>
        public const string DNFUT3 = "DNFUT3";

        /// <summary>
        /// DNFUT4.
        /// </summary>
        public const string DNFUT4 = "DNFUT4";

        /// <summary>
        /// DNFUTDATE1.
        /// </summary>
        public const string DNFUTDATE1 = "DNFUTDATE1";

        /// <summary>
        /// DNFUTDATE2.
        /// </summary>
        public const string DNFUTDATE2 = "DNFUTDATE2";

        /// <summary>
        /// DNFUTTRANS.
        /// </summary>
        public const string DNFUTTRANS = "DNFUTTRANS";

        /// <summary>
        /// DNPN.
        /// </summary>
        public const string DNPN = "DNPN";
    }

    /// <inheritdoc />
    public override string TableName => "F75C911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DNCO", "DNCO", JdeDataType.String, 10, true, true),
        new JdeField("DNDGJ", "DNDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DNICU", "DNICU", JdeDataType.Numeric, null, true, true),
        new JdeField("DNDOC", "DNDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DNLT", "DNLT", JdeDataType.String, 4, true, true),
        new JdeField("DNC75CDOC", "DNC75CDOC", JdeDataType.Numeric),
        new JdeField("DNPID", "DNPID", JdeDataType.String, 20),
        new JdeField("DNJOBN", "DNJOBN", JdeDataType.String, 20),
        new JdeField("DNUSER", "DNUSER", JdeDataType.String, 20),
        new JdeField("DNUPMT", "DNUPMT", JdeDataType.Numeric),
        new JdeField("DNUPMJ", "DNUPMJ", JdeDataType.Numeric),
        new JdeField("DNFUT1", "DNFUT1", JdeDataType.Numeric),
        new JdeField("DNFUT2", "DNFUT2", JdeDataType.Numeric),
        new JdeField("DNFUT3", "DNFUT3", JdeDataType.String, 60),
        new JdeField("DNFUT4", "DNFUT4", JdeDataType.String, 50),
        new JdeField("DNFUTDATE1", "DNFUTDATE1", JdeDataType.Numeric),
        new JdeField("DNFUTDATE2", "DNFUTDATE2", JdeDataType.Numeric),
        new JdeField("DNFUTTRANS", "DNFUTTRANS", JdeDataType.String, 2),
        new JdeField("DNPN", "DNPN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C911_0", "Primary Key on DNCO, DNDGJ, DNICU, DNDOC, DNLT", new[] { "DNCO", "DNDGJ", "DNICU", "DNDOC", "DNLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75C911_2", "Index on DNPN, DNCO", new[] { "DNPN", "DNCO" })
    };
}
