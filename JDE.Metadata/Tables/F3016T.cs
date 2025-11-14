using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3016T - .
/// </summary>
public class F3016T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KMKID1.
        /// </summary>
        public const string KMKID1 = "KMKID1";

        /// <summary>
        /// KMKID2.
        /// </summary>
        public const string KMKID2 = "KMKID2";

        /// <summary>
        /// KMCALCID.
        /// </summary>
        public const string KMCALCID = "KMCALCID";

        /// <summary>
        /// KMEV01.
        /// </summary>
        public const string KMEV01 = "KMEV01";

        /// <summary>
        /// KMPCODE.
        /// </summary>
        public const string KMPCODE = "KMPCODE";

        /// <summary>
        /// KMKLBMSG.
        /// </summary>
        public const string KMKLBMSG = "KMKLBMSG";

        /// <summary>
        /// KMDFLTYP.
        /// </summary>
        public const string KMDFLTYP = "KMDFLTYP";

        /// <summary>
        /// KMDFNC.
        /// </summary>
        public const string KMDFNC = "KMDFNC";

        /// <summary>
        /// KMKFRIP.
        /// </summary>
        public const string KMKFRIP = "KMKFRIP";

        /// <summary>
        /// KMDFMLINE.
        /// </summary>
        public const string KMDFMLINE = "KMDFMLINE";

        /// <summary>
        /// KMITM.
        /// </summary>
        public const string KMITM = "KMITM";
    }

    /// <inheritdoc />
    public override string TableName => "F3016T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KMKID1", "KMKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("KMKID2", "KMKID2", JdeDataType.Numeric),
        new JdeField("KMCALCID", "KMCALCID", JdeDataType.String, 20),
        new JdeField("KMEV01", "KMEV01", JdeDataType.String, 2),
        new JdeField("KMPCODE", "KMPCODE", JdeDataType.String, 4),
        new JdeField("KMKLBMSG", "KMKLBMSG", JdeDataType.String, 20),
        new JdeField("KMDFLTYP", "KMDFLTYP", JdeDataType.String, 6),
        new JdeField("KMDFNC", "KMDFNC", JdeDataType.Numeric),
        new JdeField("KMKFRIP", "KMKFRIP", JdeDataType.String, 2),
        new JdeField("KMDFMLINE", "KMDFMLINE", JdeDataType.String, 24),
        new JdeField("KMITM", "KMITM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3016T_0", "Primary Key on KMKID1", new[] { "KMKID1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3016T_2", "Index on KMDFMLINE, KMKFRIP, KMITM", new[] { "KMDFMLINE", "KMKFRIP", "KMITM" })
    };
}
