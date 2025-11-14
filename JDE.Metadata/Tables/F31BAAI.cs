using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31BAAI - .
/// </summary>
public class F31BAAI : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLANUM.
        /// </summary>
        public const string BLANUM = "BLANUM";

        /// <summary>
        /// BLCO.
        /// </summary>
        public const string BLCO = "BLCO";

        /// <summary>
        /// BLDCT.
        /// </summary>
        public const string BLDCT = "BLDCT";

        /// <summary>
        /// BLWEURAG.
        /// </summary>
        public const string BLWEURAG = "BLWEURAG";

        /// <summary>
        /// BLWOG.
        /// </summary>
        public const string BLWOG = "BLWOG";

        /// <summary>
        /// BLMATYP.
        /// </summary>
        public const string BLMATYP = "BLMATYP";

        /// <summary>
        /// BLWCOST.
        /// </summary>
        public const string BLWCOST = "BLWCOST";

        /// <summary>
        /// BLMCU.
        /// </summary>
        public const string BLMCU = "BLMCU";

        /// <summary>
        /// BLOBJ.
        /// </summary>
        public const string BLOBJ = "BLOBJ";

        /// <summary>
        /// BLSUB.
        /// </summary>
        public const string BLSUB = "BLSUB";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLJOBN.
        /// </summary>
        public const string BLJOBN = "BLJOBN";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLTDAY.
        /// </summary>
        public const string BLTDAY = "BLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31BAAI";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLANUM", "BLANUM", JdeDataType.Numeric, null, true, true),
        new JdeField("BLCO", "BLCO", JdeDataType.String, 10, true, true),
        new JdeField("BLDCT", "BLDCT", JdeDataType.String, 4, true, true),
        new JdeField("BLWEURAG", "BLWEURAG", JdeDataType.String, 24, true, true),
        new JdeField("BLWOG", "BLWOG", JdeDataType.String, 6, true, true),
        new JdeField("BLMATYP", "BLMATYP", JdeDataType.String, 8, true, true),
        new JdeField("BLWCOST", "BLWCOST", JdeDataType.String, 24, true, true),
        new JdeField("BLMCU", "BLMCU", JdeDataType.String, 24),
        new JdeField("BLOBJ", "BLOBJ", JdeDataType.String, 12),
        new JdeField("BLSUB", "BLSUB", JdeDataType.String, 16),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLJOBN", "BLJOBN", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLTDAY", "BLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31BAAI_0", "Primary Key on BLANUM, BLCO, BLDCT, BLMATYP, BLWOG, BLWEURAG, BLWCOST", new[] { "BLANUM", "BLCO", "BLDCT", "BLMATYP", "BLWOG", "BLWEURAG", "BLWCOST" }, isUnique: true, isPrimaryKey: true)
    };
}
