using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B51 - .
/// </summary>
public class F76B51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RICO.
        /// </summary>
        public const string RICO = "RICO";

        /// <summary>
        /// RISTRQ.
        /// </summary>
        public const string RISTRQ = "RISTRQ";

        /// <summary>
        /// RILOC.
        /// </summary>
        public const string RILOC = "RILOC";

        /// <summary>
        /// RICHGJ.
        /// </summary>
        public const string RICHGJ = "RICHGJ";

        /// <summary>
        /// RILITM.
        /// </summary>
        public const string RILITM = "RILITM";

        /// <summary>
        /// RIBCLF.
        /// </summary>
        public const string RIBCLF = "RIBCLF";

        /// <summary>
        /// RIUOM.
        /// </summary>
        public const string RIUOM = "RIUOM";

        /// <summary>
        /// RIUORG.
        /// </summary>
        public const string RIUORG = "RIUORG";

        /// <summary>
        /// RIUNCS.
        /// </summary>
        public const string RIUNCS = "RIUNCS";

        /// <summary>
        /// RIECST.
        /// </summary>
        public const string RIECST = "RIECST";

        /// <summary>
        /// RILRFL.
        /// </summary>
        public const string RILRFL = "RILRFL";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIEAP.
        /// </summary>
        public const string RIEAP = "RIEAP";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RIUPMT.
        /// </summary>
        public const string RIUPMT = "RIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RICO", "RICO", JdeDataType.String, 10, true, true),
        new JdeField("RISTRQ", "RISTRQ", JdeDataType.String, 6),
        new JdeField("RILOC", "RILOC", JdeDataType.String, 24),
        new JdeField("RICHGJ", "RICHGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RILITM", "RILITM", JdeDataType.String, 50, true, true),
        new JdeField("RIBCLF", "RIBCLF", JdeDataType.String, 20),
        new JdeField("RIUOM", "RIUOM", JdeDataType.String, 4),
        new JdeField("RIUORG", "RIUORG", JdeDataType.Numeric),
        new JdeField("RIUNCS", "RIUNCS", JdeDataType.Numeric),
        new JdeField("RIECST", "RIECST", JdeDataType.Numeric),
        new JdeField("RILRFL", "RILRFL", JdeDataType.String, 2),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIEAP", "RIEAP", JdeDataType.String, 20),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RIUPMT", "RIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B51_0", "Primary Key on RICO, RILITM, RICHGJ", new[] { "RICO", "RILITM", "RICHGJ" }, isUnique: true, isPrimaryKey: true)
    };
}
