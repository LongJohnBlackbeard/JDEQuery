using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E25 - .
/// </summary>
public class F43E25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EIAN8V.
        /// </summary>
        public const string EIAN8V = "EIAN8V";

        /// <summary>
        /// EICOMMETHD.
        /// </summary>
        public const string EICOMMETHD = "EICOMMETHD";

        /// <summary>
        /// EIEXTRNNM.
        /// </summary>
        public const string EIEXTRNNM = "EIEXTRNNM";

        /// <summary>
        /// EIDS01.
        /// </summary>
        public const string EIDS01 = "EIDS01";

        /// <summary>
        /// EIDDA1.
        /// </summary>
        public const string EIDDA1 = "EIDDA1";

        /// <summary>
        /// EIEXTRNTBL.
        /// </summary>
        public const string EIEXTRNTBL = "EIEXTRNTBL";

        /// <summary>
        /// EIUSER.
        /// </summary>
        public const string EIUSER = "EIUSER";

        /// <summary>
        /// EIPID.
        /// </summary>
        public const string EIPID = "EIPID";

        /// <summary>
        /// EIJOBN.
        /// </summary>
        public const string EIJOBN = "EIJOBN";

        /// <summary>
        /// EIUPMJ.
        /// </summary>
        public const string EIUPMJ = "EIUPMJ";

        /// <summary>
        /// EIUPMT.
        /// </summary>
        public const string EIUPMT = "EIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F43E25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EIAN8V", "EIAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("EICOMMETHD", "EICOMMETHD", JdeDataType.String, 2, true, true),
        new JdeField("EIEXTRNNM", "EIEXTRNNM", JdeDataType.String, 64, true, true),
        new JdeField("EIDS01", "EIDS01", JdeDataType.String, 160),
        new JdeField("EIDDA1", "EIDDA1", JdeDataType.String, 20),
        new JdeField("EIEXTRNTBL", "EIEXTRNTBL", JdeDataType.String, 20),
        new JdeField("EIUSER", "EIUSER", JdeDataType.String, 20),
        new JdeField("EIPID", "EIPID", JdeDataType.String, 20),
        new JdeField("EIJOBN", "EIJOBN", JdeDataType.String, 20),
        new JdeField("EIUPMJ", "EIUPMJ", JdeDataType.Numeric),
        new JdeField("EIUPMT", "EIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E25_0", "Primary Key on EIAN8V, EICOMMETHD, EIEXTRNNM", new[] { "EIAN8V", "EICOMMETHD", "EIEXTRNNM" }, isUnique: true, isPrimaryKey: true)
    };
}
