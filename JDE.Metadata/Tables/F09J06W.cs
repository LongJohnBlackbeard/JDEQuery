using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J06W - .
/// </summary>
public class F09J06W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGJVJOBS.
        /// </summary>
        public const string JGJVJOBS = "JGJVJOBS";

        /// <summary>
        /// JGJVNAME.
        /// </summary>
        public const string JGJVNAME = "JGJVNAME";

        /// <summary>
        /// JGMCU.
        /// </summary>
        public const string JGMCU = "JGMCU";

        /// <summary>
        /// JGMCUS.
        /// </summary>
        public const string JGMCUS = "JGMCUS";

        /// <summary>
        /// JGJVCO.
        /// </summary>
        public const string JGJVCO = "JGJVCO";

        /// <summary>
        /// JGJVDSC.
        /// </summary>
        public const string JGJVDSC = "JGJVDSC";

        /// <summary>
        /// JGANP.
        /// </summary>
        public const string JGANP = "JGANP";

        /// <summary>
        /// JGJVSTS.
        /// </summary>
        public const string JGJVSTS = "JGJVSTS";

        /// <summary>
        /// JGJVAPPR.
        /// </summary>
        public const string JGJVAPPR = "JGJVAPPR";

        /// <summary>
        /// JGCO.
        /// </summary>
        public const string JGCO = "JGCO";

        /// <summary>
        /// JGDL01.
        /// </summary>
        public const string JGDL01 = "JGDL01";

        /// <summary>
        /// JGUSER.
        /// </summary>
        public const string JGUSER = "JGUSER";

        /// <summary>
        /// JGMKEY.
        /// </summary>
        public const string JGMKEY = "JGMKEY";

        /// <summary>
        /// JGPID.
        /// </summary>
        public const string JGPID = "JGPID";

        /// <summary>
        /// JGJVMCO.
        /// </summary>
        public const string JGJVMCO = "JGJVMCO";

        /// <summary>
        /// JGJVBUSQ.
        /// </summary>
        public const string JGJVBUSQ = "JGJVBUSQ";
    }

    /// <inheritdoc />
    public override string TableName => "F09J06W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGJVJOBS", "JGJVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JGJVNAME", "JGJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("JGMCU", "JGMCU", JdeDataType.String, 24, true, true),
        new JdeField("JGMCUS", "JGMCUS", JdeDataType.String, 24),
        new JdeField("JGJVCO", "JGJVCO", JdeDataType.String, 10),
        new JdeField("JGJVDSC", "JGJVDSC", JdeDataType.String, 160),
        new JdeField("JGANP", "JGANP", JdeDataType.Numeric),
        new JdeField("JGJVSTS", "JGJVSTS", JdeDataType.String, 6),
        new JdeField("JGJVAPPR", "JGJVAPPR", JdeDataType.String, 2),
        new JdeField("JGCO", "JGCO", JdeDataType.String, 10),
        new JdeField("JGDL01", "JGDL01", JdeDataType.String, 60),
        new JdeField("JGUSER", "JGUSER", JdeDataType.String, 20),
        new JdeField("JGMKEY", "JGMKEY", JdeDataType.String, 30),
        new JdeField("JGPID", "JGPID", JdeDataType.String, 20),
        new JdeField("JGJVMCO", "JGJVMCO", JdeDataType.String, 10),
        new JdeField("JGJVBUSQ", "JGJVBUSQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J06W_0", "Primary Key on JGJVJOBS, JGJVNAME, JGMCU", new[] { "JGJVJOBS", "JGJVNAME", "JGMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J06W_2", "Index on JGJVJOBS, JGJVNAME, JGCO, JGMCU", new[] { "JGJVJOBS", "JGJVNAME", "JGCO", "JGMCU" }),
        new JdeIndex("F09J06W_3", "Index on JGUSER", new[] { "JGUSER" }),
        new JdeIndex("F09J06W_4", "Index on JGMCU", new[] { "JGMCU" })
    };
}
