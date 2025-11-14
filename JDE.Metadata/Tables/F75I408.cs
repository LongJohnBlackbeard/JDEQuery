using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I408 - .
/// </summary>
public class F75I408 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VCCO.
        /// </summary>
        public const string VCCO = "VCCO";

        /// <summary>
        /// VCMCU.
        /// </summary>
        public const string VCMCU = "VCMCU";

        /// <summary>
        /// VCOBJ.
        /// </summary>
        public const string VCOBJ = "VCOBJ";

        /// <summary>
        /// VCSUB.
        /// </summary>
        public const string VCSUB = "VCSUB";

        /// <summary>
        /// VCMCU0.
        /// </summary>
        public const string VCMCU0 = "VCMCU0";

        /// <summary>
        /// VCOBJ0.
        /// </summary>
        public const string VCOBJ0 = "VCOBJ0";

        /// <summary>
        /// VCSUB0.
        /// </summary>
        public const string VCSUB0 = "VCSUB0";

        /// <summary>
        /// VCMCU1.
        /// </summary>
        public const string VCMCU1 = "VCMCU1";

        /// <summary>
        /// VCOBJ1.
        /// </summary>
        public const string VCOBJ1 = "VCOBJ1";

        /// <summary>
        /// VCSUB1.
        /// </summary>
        public const string VCSUB1 = "VCSUB1";

        /// <summary>
        /// VCMCU2.
        /// </summary>
        public const string VCMCU2 = "VCMCU2";

        /// <summary>
        /// VCOBJ2.
        /// </summary>
        public const string VCOBJ2 = "VCOBJ2";

        /// <summary>
        /// VCSUB2.
        /// </summary>
        public const string VCSUB2 = "VCSUB2";

        /// <summary>
        /// VCMCU3.
        /// </summary>
        public const string VCMCU3 = "VCMCU3";

        /// <summary>
        /// VCOBJ3.
        /// </summary>
        public const string VCOBJ3 = "VCOBJ3";

        /// <summary>
        /// VCSUB4.
        /// </summary>
        public const string VCSUB4 = "VCSUB4";

        /// <summary>
        /// VCMCU4.
        /// </summary>
        public const string VCMCU4 = "VCMCU4";

        /// <summary>
        /// VCOBJ4.
        /// </summary>
        public const string VCOBJ4 = "VCOBJ4";

        /// <summary>
        /// VCSUB5.
        /// </summary>
        public const string VCSUB5 = "VCSUB5";

        /// <summary>
        /// VCMCU5.
        /// </summary>
        public const string VCMCU5 = "VCMCU5";

        /// <summary>
        /// VCOBJ5.
        /// </summary>
        public const string VCOBJ5 = "VCOBJ5";

        /// <summary>
        /// VCSUB6.
        /// </summary>
        public const string VCSUB6 = "VCSUB6";

        /// <summary>
        /// VCUSER.
        /// </summary>
        public const string VCUSER = "VCUSER";

        /// <summary>
        /// VCPID.
        /// </summary>
        public const string VCPID = "VCPID";

        /// <summary>
        /// VCJOBN.
        /// </summary>
        public const string VCJOBN = "VCJOBN";

        /// <summary>
        /// VCUPMJ.
        /// </summary>
        public const string VCUPMJ = "VCUPMJ";

        /// <summary>
        /// VCUPMT.
        /// </summary>
        public const string VCUPMT = "VCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I408";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VCCO", "VCCO", JdeDataType.String, 10, true, true),
        new JdeField("VCMCU", "VCMCU", JdeDataType.String, 24, true, true),
        new JdeField("VCOBJ", "VCOBJ", JdeDataType.String, 12),
        new JdeField("VCSUB", "VCSUB", JdeDataType.String, 16),
        new JdeField("VCMCU0", "VCMCU0", JdeDataType.String, 24),
        new JdeField("VCOBJ0", "VCOBJ0", JdeDataType.String, 12),
        new JdeField("VCSUB0", "VCSUB0", JdeDataType.String, 16),
        new JdeField("VCMCU1", "VCMCU1", JdeDataType.String, 24),
        new JdeField("VCOBJ1", "VCOBJ1", JdeDataType.String, 12),
        new JdeField("VCSUB1", "VCSUB1", JdeDataType.String, 16),
        new JdeField("VCMCU2", "VCMCU2", JdeDataType.String, 24),
        new JdeField("VCOBJ2", "VCOBJ2", JdeDataType.String, 12),
        new JdeField("VCSUB2", "VCSUB2", JdeDataType.String, 16),
        new JdeField("VCMCU3", "VCMCU3", JdeDataType.String, 24),
        new JdeField("VCOBJ3", "VCOBJ3", JdeDataType.String, 12),
        new JdeField("VCSUB4", "VCSUB4", JdeDataType.String, 16),
        new JdeField("VCMCU4", "VCMCU4", JdeDataType.String, 24),
        new JdeField("VCOBJ4", "VCOBJ4", JdeDataType.String, 12),
        new JdeField("VCSUB5", "VCSUB5", JdeDataType.String, 16),
        new JdeField("VCMCU5", "VCMCU5", JdeDataType.String, 24),
        new JdeField("VCOBJ5", "VCOBJ5", JdeDataType.String, 12),
        new JdeField("VCSUB6", "VCSUB6", JdeDataType.String, 16),
        new JdeField("VCUSER", "VCUSER", JdeDataType.String, 20),
        new JdeField("VCPID", "VCPID", JdeDataType.String, 20),
        new JdeField("VCJOBN", "VCJOBN", JdeDataType.String, 20),
        new JdeField("VCUPMJ", "VCUPMJ", JdeDataType.Numeric),
        new JdeField("VCUPMT", "VCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I408_0", "Primary Key on VCCO, VCMCU", new[] { "VCCO", "VCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
