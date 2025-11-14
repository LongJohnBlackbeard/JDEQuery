using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0010T - .
/// </summary>
public class F0010T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCCTBPI.
        /// </summary>
        public const string CCCTBPI = "CCCTBPI";

        /// <summary>
        /// CCTFUC1.
        /// </summary>
        public const string CCTFUC1 = "CCTFUC1";

        /// <summary>
        /// CCTFUC2.
        /// </summary>
        public const string CCTFUC2 = "CCTFUC2";

        /// <summary>
        /// CCTFUN1.
        /// </summary>
        public const string CCTFUN1 = "CCTFUN1";

        /// <summary>
        /// CCTFUS1.
        /// </summary>
        public const string CCTFUS1 = "CCTFUS1";

        /// <summary>
        /// CCTFUDJ.
        /// </summary>
        public const string CCTFUDJ = "CCTFUDJ";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0010T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCCTBPI", "CCCTBPI", JdeDataType.String, 2),
        new JdeField("CCTFUC1", "CCTFUC1", JdeDataType.String, 2),
        new JdeField("CCTFUC2", "CCTFUC2", JdeDataType.String, 2),
        new JdeField("CCTFUN1", "CCTFUN1", JdeDataType.Numeric),
        new JdeField("CCTFUS1", "CCTFUS1", JdeDataType.String, 80),
        new JdeField("CCTFUDJ", "CCTFUDJ", JdeDataType.Numeric),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0010T_0", "Primary Key on CCCO", new[] { "CCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
