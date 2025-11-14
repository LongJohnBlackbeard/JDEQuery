using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0140 - .
/// </summary>
public class F74U0140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACUKACMP.
        /// </summary>
        public const string ACUKACMP = "ACUKACMP";

        /// <summary>
        /// ACUKACMA.
        /// </summary>
        public const string ACUKACMA = "ACUKACMA";

        /// <summary>
        /// ACUKMSPR.
        /// </summary>
        public const string ACUKMSPR = "ACUKMSPR";

        /// <summary>
        /// ACUKMPYS.
        /// </summary>
        public const string ACUKMPYS = "ACUKMPYS";

        /// <summary>
        /// ACUKAPRQ.
        /// </summary>
        public const string ACUKAPRQ = "ACUKAPRQ";

        /// <summary>
        /// ACUKARYS.
        /// </summary>
        public const string ACUKARYS = "ACUKARYS";

        /// <summary>
        /// ACUKOVCA.
        /// </summary>
        public const string ACUKOVCA = "ACUKOVCA";

        /// <summary>
        /// ACUKOCAY.
        /// </summary>
        public const string ACUKOCAY = "ACUKOCAY";

        /// <summary>
        /// ACUKCEAS.
        /// </summary>
        public const string ACUKCEAS = "ACUKCEAS";

        /// <summary>
        /// ACUKVGAS.
        /// </summary>
        public const string ACUKVGAS = "ACUKVGAS";

        /// <summary>
        /// ACUKPGAS.
        /// </summary>
        public const string ACUKPGAS = "ACUKPGAS";

        /// <summary>
        /// ACUKRVAS.
        /// </summary>
        public const string ACUKRVAS = "ACUKRVAS";

        /// <summary>
        /// ACUKACMB.
        /// </summary>
        public const string ACUKACMB = "ACUKACMB";

        /// <summary>
        /// ACUKACME.
        /// </summary>
        public const string ACUKACME = "ACUKACME";

        /// <summary>
        /// ACUKACMR.
        /// </summary>
        public const string ACUKACMR = "ACUKACMR";

        /// <summary>
        /// ACUKACMS.
        /// </summary>
        public const string ACUKACMS = "ACUKACMS";

        /// <summary>
        /// ACUKACMQ.
        /// </summary>
        public const string ACUKACMQ = "ACUKACMQ";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACUKACMP", "ACUKACMP", JdeDataType.String, 2, true, true),
        new JdeField("ACUKACMA", "ACUKACMA", JdeDataType.String, 4),
        new JdeField("ACUKMSPR", "ACUKMSPR", JdeDataType.String, 4),
        new JdeField("ACUKMPYS", "ACUKMPYS", JdeDataType.String, 6),
        new JdeField("ACUKAPRQ", "ACUKAPRQ", JdeDataType.String, 4),
        new JdeField("ACUKARYS", "ACUKARYS", JdeDataType.String, 6),
        new JdeField("ACUKOVCA", "ACUKOVCA", JdeDataType.String, 4),
        new JdeField("ACUKOCAY", "ACUKOCAY", JdeDataType.String, 6),
        new JdeField("ACUKCEAS", "ACUKCEAS", JdeDataType.String, 2),
        new JdeField("ACUKVGAS", "ACUKVGAS", JdeDataType.String, 2),
        new JdeField("ACUKPGAS", "ACUKPGAS", JdeDataType.String, 2),
        new JdeField("ACUKRVAS", "ACUKRVAS", JdeDataType.String, 2),
        new JdeField("ACUKACMB", "ACUKACMB", JdeDataType.String, 20),
        new JdeField("ACUKACME", "ACUKACME", JdeDataType.String, 60),
        new JdeField("ACUKACMR", "ACUKACMR", JdeDataType.String, 2),
        new JdeField("ACUKACMS", "ACUKACMS", JdeDataType.Numeric),
        new JdeField("ACUKACMQ", "ACUKACMQ", JdeDataType.Numeric),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0140_0", "Primary Key on ACUKACMP", new[] { "ACUKACMP" }, isUnique: true, isPrimaryKey: true)
    };
}
