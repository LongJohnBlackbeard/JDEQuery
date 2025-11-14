using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW961 - .
/// </summary>
public class FCW961 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLJOBS.
        /// </summary>
        public const string DLJOBS = "DLJOBS";

        /// <summary>
        /// DLUKID.
        /// </summary>
        public const string DLUKID = "DLUKID";

        /// <summary>
        /// DLC9LANC.
        /// </summary>
        public const string DLC9LANC = "DLC9LANC";

        /// <summary>
        /// DLITM.
        /// </summary>
        public const string DLITM = "DLITM";

        /// <summary>
        /// DLLITM.
        /// </summary>
        public const string DLLITM = "DLLITM";

        /// <summary>
        /// DLAITM.
        /// </summary>
        public const string DLAITM = "DLAITM";

        /// <summary>
        /// DLMCU.
        /// </summary>
        public const string DLMCU = "DLMCU";

        /// <summary>
        /// DLCPNT.
        /// </summary>
        public const string DLCPNT = "DLCPNT";

        /// <summary>
        /// DLCPIT.
        /// </summary>
        public const string DLCPIT = "DLCPIT";

        /// <summary>
        /// DLCPIL.
        /// </summary>
        public const string DLCPIL = "DLCPIL";

        /// <summary>
        /// DLCPIA.
        /// </summary>
        public const string DLCPIA = "DLCPIA";

        /// <summary>
        /// DLDSC1.
        /// </summary>
        public const string DLDSC1 = "DLDSC1";

        /// <summary>
        /// DLCMCU.
        /// </summary>
        public const string DLCMCU = "DLCMCU";

        /// <summary>
        /// DLUORG.
        /// </summary>
        public const string DLUORG = "DLUORG";

        /// <summary>
        /// DLUM.
        /// </summary>
        public const string DLUM = "DLUM";

        /// <summary>
        /// DLCKAV.
        /// </summary>
        public const string DLCKAV = "DLCKAV";

        /// <summary>
        /// DLUSER.
        /// </summary>
        public const string DLUSER = "DLUSER";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";

        /// <summary>
        /// DLJOBN.
        /// </summary>
        public const string DLJOBN = "DLJOBN";

        /// <summary>
        /// DLUPMJ.
        /// </summary>
        public const string DLUPMJ = "DLUPMJ";

        /// <summary>
        /// DLUPMT.
        /// </summary>
        public const string DLUPMT = "DLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW961";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLJOBS", "DLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DLUKID", "DLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DLC9LANC", "DLC9LANC", JdeDataType.Numeric),
        new JdeField("DLITM", "DLITM", JdeDataType.Numeric),
        new JdeField("DLLITM", "DLLITM", JdeDataType.String, 50),
        new JdeField("DLAITM", "DLAITM", JdeDataType.String, 50),
        new JdeField("DLMCU", "DLMCU", JdeDataType.String, 24),
        new JdeField("DLCPNT", "DLCPNT", JdeDataType.Numeric),
        new JdeField("DLCPIT", "DLCPIT", JdeDataType.Numeric, null, true, true),
        new JdeField("DLCPIL", "DLCPIL", JdeDataType.String, 50),
        new JdeField("DLCPIA", "DLCPIA", JdeDataType.String, 50),
        new JdeField("DLDSC1", "DLDSC1", JdeDataType.String, 60),
        new JdeField("DLCMCU", "DLCMCU", JdeDataType.String, 24, true, true),
        new JdeField("DLUORG", "DLUORG", JdeDataType.Numeric),
        new JdeField("DLUM", "DLUM", JdeDataType.String, 4),
        new JdeField("DLCKAV", "DLCKAV", JdeDataType.String, 2),
        new JdeField("DLUSER", "DLUSER", JdeDataType.String, 20),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20),
        new JdeField("DLJOBN", "DLJOBN", JdeDataType.String, 20),
        new JdeField("DLUPMJ", "DLUPMJ", JdeDataType.Numeric),
        new JdeField("DLUPMT", "DLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW961_0", "Primary Key on DLJOBS, DLUKID, DLCPIT, DLCMCU", new[] { "DLJOBS", "DLUKID", "DLCPIT", "DLCMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW961_2", "Index on DLJOBS, DLCPIT, DLCMCU", new[] { "DLJOBS", "DLCPIT", "DLCMCU" })
    };
}
