using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43008_ADT - .
/// </summary>
public class F43008_ADT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDCTO.
        /// </summary>
        public const string APDCTO = "APDCTO";

        /// <summary>
        /// APARTG.
        /// </summary>
        public const string APARTG = "APARTG";

        /// <summary>
        /// APDL01.
        /// </summary>
        public const string APDL01 = "APDL01";

        /// <summary>
        /// APALIM.
        /// </summary>
        public const string APALIM = "APALIM";

        /// <summary>
        /// APRPER.
        /// </summary>
        public const string APRPER = "APRPER";

        /// <summary>
        /// APATY.
        /// </summary>
        public const string APATY = "APATY";

        /// <summary>
        /// APCFRGUID.
        /// </summary>
        public const string APCFRGUID = "APCFRGUID";

        /// <summary>
        /// APCFRMKEY.
        /// </summary>
        public const string APCFRMKEY = "APCFRMKEY";

        /// <summary>
        /// APCFRPID.
        /// </summary>
        public const string APCFRPID = "APCFRPID";

        /// <summary>
        /// APCFRUSER.
        /// </summary>
        public const string APCFRUSER = "APCFRUSER";

        /// <summary>
        /// APISDELETE.
        /// </summary>
        public const string APISDELETE = "APISDELETE";

        /// <summary>
        /// APCFRSEQN.
        /// </summary>
        public const string APCFRSEQN = "APCFRSEQN";
    }

    /// <inheritdoc />
    public override string TableName => "F43008_ADT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDCTO", "APDCTO", JdeDataType.String, 4, true, true),
        new JdeField("APARTG", "APARTG", JdeDataType.String, 24, true, true),
        new JdeField("APDL01", "APDL01", JdeDataType.String, 60),
        new JdeField("APALIM", "APALIM", JdeDataType.Numeric, null, true, true),
        new JdeField("APRPER", "APRPER", JdeDataType.Numeric, null, true, true),
        new JdeField("APATY", "APATY", JdeDataType.String, 2, true, true),
        new JdeField("APCFRGUID", "APCFRGUID", JdeDataType.String, 72),
        new JdeField("APCFRMKEY", "APCFRMKEY", JdeDataType.String, 30),
        new JdeField("APCFRPID", "APCFRPID", JdeDataType.String, 20),
        new JdeField("APCFRUSER", "APCFRUSER", JdeDataType.String, 20),
        new JdeField("APISDELETE", "APISDELETE", JdeDataType.String, 2),
        new JdeField("APCFRSEQN", "APCFRSEQN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43008_ADT_0", "Primary Key on APDCTO, APARTG, APALIM, APRPER, APATY", new[] { "APDCTO", "APARTG", "APALIM", "APRPER", "APATY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43008_ADT_3", "Index on APRPER, APDCTO, APARTG, APATY", new[] { "APRPER", "APDCTO", "APARTG", "APATY" }),
        new JdeIndex("F43008_ADT_4", "Index on APARTG", new[] { "APARTG" })
    };
}
