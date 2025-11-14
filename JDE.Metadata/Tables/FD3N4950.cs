using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N4950 - .
/// </summary>
public class FD3N4950 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCLDNM.
        /// </summary>
        public const string DCLDNM = "DCLDNM";

        /// <summary>
        /// DCVMCU.
        /// </summary>
        public const string DCVMCU = "DCVMCU";

        /// <summary>
        /// DCSHPN.
        /// </summary>
        public const string DCSHPN = "DCSHPN";

        /// <summary>
        /// DCRSSN.
        /// </summary>
        public const string DCRSSN = "DCRSSN";

        /// <summary>
        /// DCDOCO.
        /// </summary>
        public const string DCDOCO = "DCDOCO";

        /// <summary>
        /// DCDCTO.
        /// </summary>
        public const string DCDCTO = "DCDCTO";

        /// <summary>
        /// DCKCOO.
        /// </summary>
        public const string DCKCOO = "DCKCOO";

        /// <summary>
        /// DCLNID.
        /// </summary>
        public const string DCLNID = "DCLNID";

        /// <summary>
        /// DCITM.
        /// </summary>
        public const string DCITM = "DCITM";

        /// <summary>
        /// DCLOTN.
        /// </summary>
        public const string DCLOTN = "DCLOTN";

        /// <summary>
        /// DCTRQT.
        /// </summary>
        public const string DCTRQT = "DCTRQT";

        /// <summary>
        /// DCUOM.
        /// </summary>
        public const string DCUOM = "DCUOM";

        /// <summary>
        /// DCDLDT.
        /// </summary>
        public const string DCDLDT = "DCDLDT";

        /// <summary>
        /// DCDLTM.
        /// </summary>
        public const string DCDLTM = "DCDLTM";

        /// <summary>
        /// DCDL01.
        /// </summary>
        public const string DCDL01 = "DCDL01";

        /// <summary>
        /// DCDSCD.
        /// </summary>
        public const string DCDSCD = "DCDSCD";

        /// <summary>
        /// DCUSER.
        /// </summary>
        public const string DCUSER = "DCUSER";

        /// <summary>
        /// DCPID.
        /// </summary>
        public const string DCPID = "DCPID";

        /// <summary>
        /// DCJOBN.
        /// </summary>
        public const string DCJOBN = "DCJOBN";

        /// <summary>
        /// DCUPMJ.
        /// </summary>
        public const string DCUPMJ = "DCUPMJ";

        /// <summary>
        /// DCTDAY.
        /// </summary>
        public const string DCTDAY = "DCTDAY";

        /// <summary>
        /// DCSQOR.
        /// </summary>
        public const string DCSQOR = "DCSQOR";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N4950";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCLDNM", "DCLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("DCVMCU", "DCVMCU", JdeDataType.String, 24, true, true),
        new JdeField("DCSHPN", "DCSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("DCRSSN", "DCRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("DCDOCO", "DCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DCDCTO", "DCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DCKCOO", "DCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DCLNID", "DCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DCITM", "DCITM", JdeDataType.Numeric),
        new JdeField("DCLOTN", "DCLOTN", JdeDataType.String, 60),
        new JdeField("DCTRQT", "DCTRQT", JdeDataType.Numeric),
        new JdeField("DCUOM", "DCUOM", JdeDataType.String, 4),
        new JdeField("DCDLDT", "DCDLDT", JdeDataType.Numeric),
        new JdeField("DCDLTM", "DCDLTM", JdeDataType.Numeric),
        new JdeField("DCDL01", "DCDL01", JdeDataType.String, 60),
        new JdeField("DCDSCD", "DCDSCD", JdeDataType.String, 2),
        new JdeField("DCUSER", "DCUSER", JdeDataType.String, 20),
        new JdeField("DCPID", "DCPID", JdeDataType.String, 20),
        new JdeField("DCJOBN", "DCJOBN", JdeDataType.String, 20),
        new JdeField("DCUPMJ", "DCUPMJ", JdeDataType.Numeric),
        new JdeField("DCTDAY", "DCTDAY", JdeDataType.Numeric),
        new JdeField("DCSQOR", "DCSQOR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N4950_0", "Primary Key on DCLDNM, DCVMCU, DCSHPN, DCRSSN, DCDOCO, DCDCTO, DCKCOO, DCLNID", new[] { "DCLDNM", "DCVMCU", "DCSHPN", "DCRSSN", "DCDOCO", "DCDCTO", "DCKCOO", "DCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
