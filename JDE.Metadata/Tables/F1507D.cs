using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1507D - .
/// </summary>
public class F1507D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NHMCU.
        /// </summary>
        public const string NHMCU = "NHMCU";

        /// <summary>
        /// NHUNIT.
        /// </summary>
        public const string NHUNIT = "NHUNIT";

        /// <summary>
        /// NHLNGP.
        /// </summary>
        public const string NHLNGP = "NHLNGP";

        /// <summary>
        /// NHDL01.
        /// </summary>
        public const string NHDL01 = "NHDL01";

        /// <summary>
        /// NHDL02.
        /// </summary>
        public const string NHDL02 = "NHDL02";

        /// <summary>
        /// NHDL03.
        /// </summary>
        public const string NHDL03 = "NHDL03";

        /// <summary>
        /// NHDL04.
        /// </summary>
        public const string NHDL04 = "NHDL04";

        /// <summary>
        /// NHDL05.
        /// </summary>
        public const string NHDL05 = "NHDL05";

        /// <summary>
        /// NHUSER.
        /// </summary>
        public const string NHUSER = "NHUSER";

        /// <summary>
        /// NHPID.
        /// </summary>
        public const string NHPID = "NHPID";

        /// <summary>
        /// NHUPMJ.
        /// </summary>
        public const string NHUPMJ = "NHUPMJ";

        /// <summary>
        /// NHUPMT.
        /// </summary>
        public const string NHUPMT = "NHUPMT";

        /// <summary>
        /// NHJOBN.
        /// </summary>
        public const string NHJOBN = "NHJOBN";

        /// <summary>
        /// NHTORG.
        /// </summary>
        public const string NHTORG = "NHTORG";

        /// <summary>
        /// NHENTJ.
        /// </summary>
        public const string NHENTJ = "NHENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1507D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NHMCU", "NHMCU", JdeDataType.String, 24, true, true),
        new JdeField("NHUNIT", "NHUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NHLNGP", "NHLNGP", JdeDataType.String, 4, true, true),
        new JdeField("NHDL01", "NHDL01", JdeDataType.String, 60),
        new JdeField("NHDL02", "NHDL02", JdeDataType.String, 60),
        new JdeField("NHDL03", "NHDL03", JdeDataType.String, 60),
        new JdeField("NHDL04", "NHDL04", JdeDataType.String, 60),
        new JdeField("NHDL05", "NHDL05", JdeDataType.String, 60),
        new JdeField("NHUSER", "NHUSER", JdeDataType.String, 20),
        new JdeField("NHPID", "NHPID", JdeDataType.String, 20),
        new JdeField("NHUPMJ", "NHUPMJ", JdeDataType.Numeric),
        new JdeField("NHUPMT", "NHUPMT", JdeDataType.Numeric),
        new JdeField("NHJOBN", "NHJOBN", JdeDataType.String, 20),
        new JdeField("NHTORG", "NHTORG", JdeDataType.String, 20),
        new JdeField("NHENTJ", "NHENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1507D_0", "Primary Key on NHMCU, NHUNIT, NHLNGP", new[] { "NHMCU", "NHUNIT", "NHLNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
