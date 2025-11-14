using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98EVHDR - .
/// </summary>
public class F98EVHDR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHPRODID.
        /// </summary>
        public const string EHPRODID = "EHPRODID";

        /// <summary>
        /// EHOBJTYPE.
        /// </summary>
        public const string EHOBJTYPE = "EHOBJTYPE";

        /// <summary>
        /// EHDSC2.
        /// </summary>
        public const string EHDSC2 = "EHDSC2";

        /// <summary>
        /// EHEVENT1.
        /// </summary>
        public const string EHEVENT1 = "EHEVENT1";

        /// <summary>
        /// EHEVTYPE.
        /// </summary>
        public const string EHEVTYPE = "EHEVTYPE";

        /// <summary>
        /// EHEVDSC1.
        /// </summary>
        public const string EHEVDSC1 = "EHEVDSC1";

        /// <summary>
        /// EHDSC1.
        /// </summary>
        public const string EHDSC1 = "EHDSC1";

        /// <summary>
        /// EHEVDEFNM.
        /// </summary>
        public const string EHEVDEFNM = "EHEVDEFNM";

        /// <summary>
        /// EHEVPARENT.
        /// </summary>
        public const string EHEVPARENT = "EHEVPARENT";

        /// <summary>
        /// EHHELPID1.
        /// </summary>
        public const string EHHELPID1 = "EHHELPID1";
    }

    /// <inheritdoc />
    public override string TableName => "F98EVHDR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHPRODID", "EHPRODID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHOBJTYPE", "EHOBJTYPE", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDSC2", "EHDSC2", JdeDataType.String, 60),
        new JdeField("EHEVENT1", "EHEVENT1", JdeDataType.Numeric, null, true, true),
        new JdeField("EHEVTYPE", "EHEVTYPE", JdeDataType.Numeric),
        new JdeField("EHEVDSC1", "EHEVDSC1", JdeDataType.Numeric),
        new JdeField("EHDSC1", "EHDSC1", JdeDataType.String, 60),
        new JdeField("EHEVDEFNM", "EHEVDEFNM", JdeDataType.String, 60),
        new JdeField("EHEVPARENT", "EHEVPARENT", JdeDataType.Numeric),
        new JdeField("EHHELPID1", "EHHELPID1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98EVHDR_0", "Primary Key on EHPRODID, EHOBJTYPE, EHEVENT1", new[] { "EHPRODID", "EHOBJTYPE", "EHEVENT1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98EVHDR_4", "Index on EHPRODID", new[] { "EHPRODID" }),
        new JdeIndex("F98EVHDR_5", "Index on EHDSC1", new[] { "EHDSC1" })
    };
}
