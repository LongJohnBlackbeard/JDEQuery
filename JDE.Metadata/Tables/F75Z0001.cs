using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0001 - .
/// </summary>
public class F75Z0001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z1PDBA.
        /// </summary>
        public const string Z1PDBA = "Z1PDBA";

        /// <summary>
        /// Z1EDTF.
        /// </summary>
        public const string Z1EDTF = "Z1EDTF";

        /// <summary>
        /// Z1EDTT.
        /// </summary>
        public const string Z1EDTT = "Z1EDTT";

        /// <summary>
        /// Z1AN8.
        /// </summary>
        public const string Z1AN8 = "Z1AN8";

        /// <summary>
        /// Z1PMDBA.
        /// </summary>
        public const string Z1PMDBA = "Z1PMDBA";

        /// <summary>
        /// Z1EFOSPL.
        /// </summary>
        public const string Z1EFOSPL = "Z1EFOSPL";

        /// <summary>
        /// Z1EFOPDBA.
        /// </summary>
        public const string Z1EFOPDBA = "Z1EFOPDBA";

        /// <summary>
        /// Z1EFOSC.
        /// </summary>
        public const string Z1EFOSC = "Z1EFOSC";

        /// <summary>
        /// Z1EFOLSL.
        /// </summary>
        public const string Z1EFOLSL = "Z1EFOLSL";

        /// <summary>
        /// Z1SECDBA.
        /// </summary>
        public const string Z1SECDBA = "Z1SECDBA";

        /// <summary>
        /// Z1EFOSDBA.
        /// </summary>
        public const string Z1EFOSDBA = "Z1EFOSDBA";

        /// <summary>
        /// Z1UPMJ.
        /// </summary>
        public const string Z1UPMJ = "Z1UPMJ";

        /// <summary>
        /// Z1UPMT.
        /// </summary>
        public const string Z1UPMT = "Z1UPMT";

        /// <summary>
        /// Z1PID.
        /// </summary>
        public const string Z1PID = "Z1PID";

        /// <summary>
        /// Z1USER.
        /// </summary>
        public const string Z1USER = "Z1USER";

        /// <summary>
        /// Z1JOBN.
        /// </summary>
        public const string Z1JOBN = "Z1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z1PDBA", "Z1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Z1EDTF", "Z1EDTF", JdeDataType.Numeric, null, true, true),
        new JdeField("Z1EDTT", "Z1EDTT", JdeDataType.Numeric),
        new JdeField("Z1AN8", "Z1AN8", JdeDataType.Numeric),
        new JdeField("Z1PMDBA", "Z1PMDBA", JdeDataType.Numeric),
        new JdeField("Z1EFOSPL", "Z1EFOSPL", JdeDataType.String, 2),
        new JdeField("Z1EFOPDBA", "Z1EFOPDBA", JdeDataType.String, 2),
        new JdeField("Z1EFOSC", "Z1EFOSC", JdeDataType.String, 2),
        new JdeField("Z1EFOLSL", "Z1EFOLSL", JdeDataType.String, 2),
        new JdeField("Z1SECDBA", "Z1SECDBA", JdeDataType.Numeric),
        new JdeField("Z1EFOSDBA", "Z1EFOSDBA", JdeDataType.String, 2),
        new JdeField("Z1UPMJ", "Z1UPMJ", JdeDataType.Numeric),
        new JdeField("Z1UPMT", "Z1UPMT", JdeDataType.Numeric),
        new JdeField("Z1PID", "Z1PID", JdeDataType.String, 20),
        new JdeField("Z1USER", "Z1USER", JdeDataType.String, 20),
        new JdeField("Z1JOBN", "Z1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0001_0", "Primary Key on Z1PDBA, Z1EDTF", new[] { "Z1PDBA", "Z1EDTF" }, isUnique: true, isPrimaryKey: true)
    };
}
