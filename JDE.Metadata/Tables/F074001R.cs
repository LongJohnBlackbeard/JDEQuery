using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F074001R - .
/// </summary>
public class F074001R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NHSCOD.
        /// </summary>
        public const string NHSCOD = "NHSCOD";

        /// <summary>
        /// NHRTID.
        /// </summary>
        public const string NHRTID = "NHRTID";

        /// <summary>
        /// NHRTVE.
        /// </summary>
        public const string NHRTVE = "NHRTVE";

        /// <summary>
        /// NHDL01.
        /// </summary>
        public const string NHDL01 = "NHDL01";

        /// <summary>
        /// NHRTIDNH.
        /// </summary>
        public const string NHRTIDNH = "NHRTIDNH";

        /// <summary>
        /// NHVERSNH.
        /// </summary>
        public const string NHVERSNH = "NHVERSNH";

        /// <summary>
        /// NHDL02.
        /// </summary>
        public const string NHDL02 = "NHDL02";

        /// <summary>
        /// NHOFNH.
        /// </summary>
        public const string NHOFNH = "NHOFNH";

        /// <summary>
        /// NHSTRNH.
        /// </summary>
        public const string NHSTRNH = "NHSTRNH";

        /// <summary>
        /// NHRPTTYP.
        /// </summary>
        public const string NHRPTTYP = "NHRPTTYP";

        /// <summary>
        /// NHUPMJ.
        /// </summary>
        public const string NHUPMJ = "NHUPMJ";

        /// <summary>
        /// NHUPMT.
        /// </summary>
        public const string NHUPMT = "NHUPMT";

        /// <summary>
        /// NHPID.
        /// </summary>
        public const string NHPID = "NHPID";

        /// <summary>
        /// NHJOBN.
        /// </summary>
        public const string NHJOBN = "NHJOBN";

        /// <summary>
        /// NHUSER.
        /// </summary>
        public const string NHUSER = "NHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F074001R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NHSCOD", "NHSCOD", JdeDataType.String, 6, true, true),
        new JdeField("NHRTID", "NHRTID", JdeDataType.String, 20, true, true),
        new JdeField("NHRTVE", "NHRTVE", JdeDataType.String, 20, true, true),
        new JdeField("NHDL01", "NHDL01", JdeDataType.String, 60),
        new JdeField("NHRTIDNH", "NHRTIDNH", JdeDataType.String, 20),
        new JdeField("NHVERSNH", "NHVERSNH", JdeDataType.String, 20),
        new JdeField("NHDL02", "NHDL02", JdeDataType.String, 60),
        new JdeField("NHOFNH", "NHOFNH", JdeDataType.String, 2),
        new JdeField("NHSTRNH", "NHSTRNH", JdeDataType.String, 2),
        new JdeField("NHRPTTYP", "NHRPTTYP", JdeDataType.String, 2),
        new JdeField("NHUPMJ", "NHUPMJ", JdeDataType.Numeric),
        new JdeField("NHUPMT", "NHUPMT", JdeDataType.Numeric),
        new JdeField("NHPID", "NHPID", JdeDataType.String, 20),
        new JdeField("NHJOBN", "NHJOBN", JdeDataType.String, 20),
        new JdeField("NHUSER", "NHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F074001R_0", "Primary Key on NHSCOD, NHRTID, NHRTVE", new[] { "NHSCOD", "NHRTID", "NHRTVE" }, isUnique: true, isPrimaryKey: true)
    };
}
