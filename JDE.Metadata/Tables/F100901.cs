using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F100901 - .
/// </summary>
public class F100901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRAID.
        /// </summary>
        public const string FRAID = "FRAID";

        /// <summary>
        /// FRDL01.
        /// </summary>
        public const string FRDL01 = "FRDL01";

        /// <summary>
        /// FRACCTY.
        /// </summary>
        public const string FRACCTY = "FRACCTY";

        /// <summary>
        /// FRCO.
        /// </summary>
        public const string FRCO = "FRCO";

        /// <summary>
        /// FRMCU.
        /// </summary>
        public const string FRMCU = "FRMCU";

        /// <summary>
        /// FRLDOBJ3.
        /// </summary>
        public const string FRLDOBJ3 = "FRLDOBJ3";

        /// <summary>
        /// FRLDSUB3.
        /// </summary>
        public const string FRLDSUB3 = "FRLDSUB3";

        /// <summary>
        /// FRDESC3.
        /// </summary>
        public const string FRDESC3 = "FRDESC3";

        /// <summary>
        /// FRLDOBJ4.
        /// </summary>
        public const string FRLDOBJ4 = "FRLDOBJ4";

        /// <summary>
        /// FRDESC4.
        /// </summary>
        public const string FRDESC4 = "FRDESC4";

        /// <summary>
        /// FRLDSUB4.
        /// </summary>
        public const string FRLDSUB4 = "FRLDSUB4";

        /// <summary>
        /// FRLDOBJ5.
        /// </summary>
        public const string FRLDOBJ5 = "FRLDOBJ5";

        /// <summary>
        /// FRDESC5.
        /// </summary>
        public const string FRDESC5 = "FRDESC5";

        /// <summary>
        /// FRLDSUB5.
        /// </summary>
        public const string FRLDSUB5 = "FRLDSUB5";

        /// <summary>
        /// FRLDOBJ6.
        /// </summary>
        public const string FRLDOBJ6 = "FRLDOBJ6";

        /// <summary>
        /// FRLDSUB6.
        /// </summary>
        public const string FRLDSUB6 = "FRLDSUB6";

        /// <summary>
        /// FRDESC6.
        /// </summary>
        public const string FRDESC6 = "FRDESC6";

        /// <summary>
        /// FRLDOBJ7.
        /// </summary>
        public const string FRLDOBJ7 = "FRLDOBJ7";

        /// <summary>
        /// FRLDSUB7.
        /// </summary>
        public const string FRLDSUB7 = "FRLDSUB7";

        /// <summary>
        /// FRDESC7.
        /// </summary>
        public const string FRDESC7 = "FRDESC7";

        /// <summary>
        /// FRLDOBJ8.
        /// </summary>
        public const string FRLDOBJ8 = "FRLDOBJ8";

        /// <summary>
        /// FRLDSUB8.
        /// </summary>
        public const string FRLDSUB8 = "FRLDSUB8";

        /// <summary>
        /// FRDESC8.
        /// </summary>
        public const string FRDESC8 = "FRDESC8";

        /// <summary>
        /// FRLDOBJ9.
        /// </summary>
        public const string FRLDOBJ9 = "FRLDOBJ9";

        /// <summary>
        /// FRLDSUB9.
        /// </summary>
        public const string FRLDSUB9 = "FRLDSUB9";

        /// <summary>
        /// FRDESC9.
        /// </summary>
        public const string FRDESC9 = "FRDESC9";

        /// <summary>
        /// FRLDA.
        /// </summary>
        public const string FRLDA = "FRLDA";

        /// <summary>
        /// FRPID.
        /// </summary>
        public const string FRPID = "FRPID";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRJOBN.
        /// </summary>
        public const string FRJOBN = "FRJOBN";

        /// <summary>
        /// FRUPMJ.
        /// </summary>
        public const string FRUPMJ = "FRUPMJ";

        /// <summary>
        /// FRUPMT.
        /// </summary>
        public const string FRUPMT = "FRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F100901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRAID", "FRAID", JdeDataType.String, 16, true, true),
        new JdeField("FRDL01", "FRDL01", JdeDataType.String, 60),
        new JdeField("FRACCTY", "FRACCTY", JdeDataType.String, 12),
        new JdeField("FRCO", "FRCO", JdeDataType.String, 10),
        new JdeField("FRMCU", "FRMCU", JdeDataType.String, 24),
        new JdeField("FRLDOBJ3", "FRLDOBJ3", JdeDataType.String, 12),
        new JdeField("FRLDSUB3", "FRLDSUB3", JdeDataType.String, 16),
        new JdeField("FRDESC3", "FRDESC3", JdeDataType.String, 60),
        new JdeField("FRLDOBJ4", "FRLDOBJ4", JdeDataType.String, 12),
        new JdeField("FRDESC4", "FRDESC4", JdeDataType.String, 60),
        new JdeField("FRLDSUB4", "FRLDSUB4", JdeDataType.String, 16),
        new JdeField("FRLDOBJ5", "FRLDOBJ5", JdeDataType.String, 12),
        new JdeField("FRDESC5", "FRDESC5", JdeDataType.String, 60),
        new JdeField("FRLDSUB5", "FRLDSUB5", JdeDataType.String, 16),
        new JdeField("FRLDOBJ6", "FRLDOBJ6", JdeDataType.String, 12),
        new JdeField("FRLDSUB6", "FRLDSUB6", JdeDataType.String, 16),
        new JdeField("FRDESC6", "FRDESC6", JdeDataType.String, 60),
        new JdeField("FRLDOBJ7", "FRLDOBJ7", JdeDataType.String, 12),
        new JdeField("FRLDSUB7", "FRLDSUB7", JdeDataType.String, 16),
        new JdeField("FRDESC7", "FRDESC7", JdeDataType.String, 60),
        new JdeField("FRLDOBJ8", "FRLDOBJ8", JdeDataType.String, 12),
        new JdeField("FRLDSUB8", "FRLDSUB8", JdeDataType.String, 16),
        new JdeField("FRDESC8", "FRDESC8", JdeDataType.String, 60),
        new JdeField("FRLDOBJ9", "FRLDOBJ9", JdeDataType.String, 12),
        new JdeField("FRLDSUB9", "FRLDSUB9", JdeDataType.String, 16),
        new JdeField("FRDESC9", "FRDESC9", JdeDataType.String, 60),
        new JdeField("FRLDA", "FRLDA", JdeDataType.String, 2),
        new JdeField("FRPID", "FRPID", JdeDataType.String, 20),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRJOBN", "FRJOBN", JdeDataType.String, 20),
        new JdeField("FRUPMJ", "FRUPMJ", JdeDataType.Numeric),
        new JdeField("FRUPMT", "FRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F100901_0", "Primary Key on FRAID", new[] { "FRAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F100901_2", "Index on FRMCU, FRAID", new[] { "FRMCU", "FRAID" })
    };
}
