using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y011 - .
/// </summary>
public class F74Y011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MPTXA1.
        /// </summary>
        public const string MPTXA1 = "MPTXA1";

        /// <summary>
        /// MPITM.
        /// </summary>
        public const string MPITM = "MPITM";

        /// <summary>
        /// MPI74MPCL.
        /// </summary>
        public const string MPI74MPCL = "MPI74MPCL";

        /// <summary>
        /// MPFFG1.
        /// </summary>
        public const string MPFFG1 = "MPFFG1";

        /// <summary>
        /// MPUSER.
        /// </summary>
        public const string MPUSER = "MPUSER";

        /// <summary>
        /// MPJOBN.
        /// </summary>
        public const string MPJOBN = "MPJOBN";

        /// <summary>
        /// MPPID.
        /// </summary>
        public const string MPPID = "MPPID";

        /// <summary>
        /// MPUPMJ.
        /// </summary>
        public const string MPUPMJ = "MPUPMJ";

        /// <summary>
        /// MPUPMT.
        /// </summary>
        public const string MPUPMT = "MPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MPTXA1", "MPTXA1", JdeDataType.String, 20, true, true),
        new JdeField("MPITM", "MPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MPI74MPCL", "MPI74MPCL", JdeDataType.Numeric),
        new JdeField("MPFFG1", "MPFFG1", JdeDataType.String, 2),
        new JdeField("MPUSER", "MPUSER", JdeDataType.String, 20),
        new JdeField("MPJOBN", "MPJOBN", JdeDataType.String, 20),
        new JdeField("MPPID", "MPPID", JdeDataType.String, 20),
        new JdeField("MPUPMJ", "MPUPMJ", JdeDataType.Numeric),
        new JdeField("MPUPMT", "MPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y011_0", "Primary Key on MPTXA1, MPITM", new[] { "MPTXA1", "MPITM" }, isUnique: true, isPrimaryKey: true)
    };
}
