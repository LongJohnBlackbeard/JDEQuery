using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW97 - .
/// </summary>
public class FCW97 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMJOBS.
        /// </summary>
        public const string GMJOBS = "GMJOBS";

        /// <summary>
        /// GMUKID.
        /// </summary>
        public const string GMUKID = "GMUKID";

        /// <summary>
        /// GMDCTO.
        /// </summary>
        public const string GMDCTO = "GMDCTO";

        /// <summary>
        /// GMMSGT.
        /// </summary>
        public const string GMMSGT = "GMMSGT";

        /// <summary>
        /// GMITM.
        /// </summary>
        public const string GMITM = "GMITM";

        /// <summary>
        /// GMMCU.
        /// </summary>
        public const string GMMCU = "GMMCU";

        /// <summary>
        /// GMTRQT.
        /// </summary>
        public const string GMTRQT = "GMTRQT";

        /// <summary>
        /// GMSTRT.
        /// </summary>
        public const string GMSTRT = "GMSTRT";

        /// <summary>
        /// GMDRQJ.
        /// </summary>
        public const string GMDRQJ = "GMDRQJ";

        /// <summary>
        /// GMLITM.
        /// </summary>
        public const string GMLITM = "GMLITM";

        /// <summary>
        /// GMAITM.
        /// </summary>
        public const string GMAITM = "GMAITM";

        /// <summary>
        /// GMDL01.
        /// </summary>
        public const string GMDL01 = "GMDL01";

        /// <summary>
        /// GMUOM8.
        /// </summary>
        public const string GMUOM8 = "GMUOM8";

        /// <summary>
        /// GMMMCU.
        /// </summary>
        public const string GMMMCU = "GMMMCU";

        /// <summary>
        /// GMSRP1.
        /// </summary>
        public const string GMSRP1 = "GMSRP1";

        /// <summary>
        /// GMSRP2.
        /// </summary>
        public const string GMSRP2 = "GMSRP2";

        /// <summary>
        /// GMSRP3.
        /// </summary>
        public const string GMSRP3 = "GMSRP3";

        /// <summary>
        /// GMSRP4.
        /// </summary>
        public const string GMSRP4 = "GMSRP4";

        /// <summary>
        /// GMSRP5.
        /// </summary>
        public const string GMSRP5 = "GMSRP5";

        /// <summary>
        /// GMSRP6.
        /// </summary>
        public const string GMSRP6 = "GMSRP6";

        /// <summary>
        /// GMSRP7.
        /// </summary>
        public const string GMSRP7 = "GMSRP7";

        /// <summary>
        /// GMSRP8.
        /// </summary>
        public const string GMSRP8 = "GMSRP8";

        /// <summary>
        /// GMSRP9.
        /// </summary>
        public const string GMSRP9 = "GMSRP9";

        /// <summary>
        /// GMSRP0.
        /// </summary>
        public const string GMSRP0 = "GMSRP0";

        /// <summary>
        /// GMPRP1.
        /// </summary>
        public const string GMPRP1 = "GMPRP1";

        /// <summary>
        /// GMPRP2.
        /// </summary>
        public const string GMPRP2 = "GMPRP2";

        /// <summary>
        /// GMPRP3.
        /// </summary>
        public const string GMPRP3 = "GMPRP3";

        /// <summary>
        /// GMPRP4.
        /// </summary>
        public const string GMPRP4 = "GMPRP4";

        /// <summary>
        /// GMPRP5.
        /// </summary>
        public const string GMPRP5 = "GMPRP5";

        /// <summary>
        /// GMPRP6.
        /// </summary>
        public const string GMPRP6 = "GMPRP6";

        /// <summary>
        /// GMPRP7.
        /// </summary>
        public const string GMPRP7 = "GMPRP7";

        /// <summary>
        /// GMPRP8.
        /// </summary>
        public const string GMPRP8 = "GMPRP8";

        /// <summary>
        /// GMPRP9.
        /// </summary>
        public const string GMPRP9 = "GMPRP9";

        /// <summary>
        /// GMPRP0.
        /// </summary>
        public const string GMPRP0 = "GMPRP0";

        /// <summary>
        /// GMUSER.
        /// </summary>
        public const string GMUSER = "GMUSER";

        /// <summary>
        /// GMPID.
        /// </summary>
        public const string GMPID = "GMPID";

        /// <summary>
        /// GMJOBN.
        /// </summary>
        public const string GMJOBN = "GMJOBN";

        /// <summary>
        /// GMUPMJ.
        /// </summary>
        public const string GMUPMJ = "GMUPMJ";

        /// <summary>
        /// GMUPMT.
        /// </summary>
        public const string GMUPMT = "GMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW97";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMJOBS", "GMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GMUKID", "GMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GMDCTO", "GMDCTO", JdeDataType.String, 4),
        new JdeField("GMMSGT", "GMMSGT", JdeDataType.String, 2),
        new JdeField("GMITM", "GMITM", JdeDataType.Numeric),
        new JdeField("GMMCU", "GMMCU", JdeDataType.String, 24),
        new JdeField("GMTRQT", "GMTRQT", JdeDataType.Numeric),
        new JdeField("GMSTRT", "GMSTRT", JdeDataType.Numeric),
        new JdeField("GMDRQJ", "GMDRQJ", JdeDataType.Numeric),
        new JdeField("GMLITM", "GMLITM", JdeDataType.String, 50),
        new JdeField("GMAITM", "GMAITM", JdeDataType.String, 50),
        new JdeField("GMDL01", "GMDL01", JdeDataType.String, 60),
        new JdeField("GMUOM8", "GMUOM8", JdeDataType.String, 4),
        new JdeField("GMMMCU", "GMMMCU", JdeDataType.String, 24),
        new JdeField("GMSRP1", "GMSRP1", JdeDataType.String, 6),
        new JdeField("GMSRP2", "GMSRP2", JdeDataType.String, 6),
        new JdeField("GMSRP3", "GMSRP3", JdeDataType.String, 6),
        new JdeField("GMSRP4", "GMSRP4", JdeDataType.String, 6),
        new JdeField("GMSRP5", "GMSRP5", JdeDataType.String, 6),
        new JdeField("GMSRP6", "GMSRP6", JdeDataType.String, 12),
        new JdeField("GMSRP7", "GMSRP7", JdeDataType.String, 12),
        new JdeField("GMSRP8", "GMSRP8", JdeDataType.String, 12),
        new JdeField("GMSRP9", "GMSRP9", JdeDataType.String, 12),
        new JdeField("GMSRP0", "GMSRP0", JdeDataType.String, 12),
        new JdeField("GMPRP1", "GMPRP1", JdeDataType.String, 6),
        new JdeField("GMPRP2", "GMPRP2", JdeDataType.String, 6),
        new JdeField("GMPRP3", "GMPRP3", JdeDataType.String, 6),
        new JdeField("GMPRP4", "GMPRP4", JdeDataType.String, 6),
        new JdeField("GMPRP5", "GMPRP5", JdeDataType.String, 6),
        new JdeField("GMPRP6", "GMPRP6", JdeDataType.String, 12),
        new JdeField("GMPRP7", "GMPRP7", JdeDataType.String, 12),
        new JdeField("GMPRP8", "GMPRP8", JdeDataType.String, 12),
        new JdeField("GMPRP9", "GMPRP9", JdeDataType.String, 12),
        new JdeField("GMPRP0", "GMPRP0", JdeDataType.String, 12),
        new JdeField("GMUSER", "GMUSER", JdeDataType.String, 20),
        new JdeField("GMPID", "GMPID", JdeDataType.String, 20),
        new JdeField("GMJOBN", "GMJOBN", JdeDataType.String, 20),
        new JdeField("GMUPMJ", "GMUPMJ", JdeDataType.Numeric),
        new JdeField("GMUPMT", "GMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW97_0", "Primary Key on GMJOBS, GMUKID", new[] { "GMJOBS", "GMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW97_3", "Index on GMITM, GMMCU, GMDRQJ, GMSTRT", new[] { "GMITM", "GMMCU", "GMDRQJ", "GMSTRT" })
    };
}
